# Aniflex

Prototipo local con clientes WinForms y React, GraphQL Java, REST Java y MongoDB Community.

## Iniciar en Windows

Requisitos: MongoDB Community, JDK 21 o superior con `JAVA_HOME`, SDK .NET 10 y,
para React, Node.js y npm. Los dos servicios incluyen Maven Wrapper.
Abre una terminal por proceso desde la raíz del repositorio.

### 1. MongoDB

Inicia MongoDB local. Ambos servicios usan `mongodb://localhost:27017`, pero cada
uno abre su propia base de datos. Compass permite inspeccionar ambas con esa dirección.

| Servicio | Base de datos | Colecciones propias |
| --- | --- | --- |
| GraphQL | `Aniflex_AB` | `series` y `episodios` |
| REST | `Aniflex_C` | `estudios`, incluidas sus relaciones `SeriesIds` |

La base antigua `Aniflex` no se modifica ni se migra automáticamente.

### 2. REST Java — puerto 8081

```powershell
Set-Location .\servicio-rest
.\mvnw.cmd spring-boot:run
```

Espera el mensaje de inicio en el puerto 8081. La consulta siguiente devuelve
una lista vacía al comenzar, sin necesitar que GraphQL esté encendido todavía:

```powershell
Invoke-RestMethod http://localhost:8081/api/estudios/
```

### 3. GraphQL Java — puerto 8080

En otra terminal, desde la raíz:

```powershell
Set-Location .\aniflexprototipo3
.\mvnw.cmd spring-boot:run
```

En [GraphiQL](http://localhost:8080/graphiql):

```graphql
query {
  listarSeries { id codigo titulo estudioId }
  listarEpisodios { id codigo titulo }
  listarEstudios { id codigo nombre series { id codigo titulo } }
}
```

### 4. Clientes

WinForms, desde la raíz:

```powershell
dotnet run --project .\cliente-.NET\Aniflex.Client\Aniflex.Client.csproj
```

React, en otra terminal desde la raíz:

```powershell
Set-Location .\cliente-react
npm ci
npm run dev
```

Los dos clientes consumen GraphQL y ofrecen las operaciones de estudios, series
y episodios. Los listados esperan Cargar o Filtrar. Limpiar vacía los criterios
y la tabla. Las búsquedas individuales y la selección de series para un estudio
usan el ID ingresado por el usuario; las referencias internas usan ObjectId.

## Sesiones de prueba y cierre

El modo de prototipo está activado por defecto en ambos servicios mediante
`aniflex.prototipo.limpiar=true`:

- Antes de atender peticiones, cada servicio vacía **solo sus colecciones**.
- Al detener Spring normalmente con `Ctrl+C`, vuelve a vaciarlas.
- No se cargan datos de ejemplo automáticamente. Cada ensayo comienza vacío.
- Los índices y las colecciones se conservan; los documentos de la prueba se eliminan.

Para terminar un ensayo, cierra los clientes y pulsa `Ctrl+C` en las terminales
de **GraphQL y REST**; detén también Vite si usaste React. Cerrar una pestaña o
WinForms no detiene los microservicios ni elimina datos por sí solo, pues puede
haber varios clientes conectados.

Si se fuerza el cierre del proceso, se interrumpe MongoDB o se apaga el equipo,
no se puede garantizar la limpieza en ese instante: el siguiente arranque del
servicio elimina los documentos pendientes antes de aceptar consultas. Para
comenzar una sesión nueva, reinicia ambos servicios, no solamente uno.

Los datos reales ingresados durante el ensayo también son desechables. Para una
sesión que deba conservarlos, configura `aniflex.prototipo.limpiar=false` en ambos
servicios antes de iniciarlos.

## Responsabilidades y comunicación entre microservicios

```text
WinForms / React ──GraphQL HTTP──> GraphQL Java ──MongoDB──> Aniflex_AB
                                      │  ▲
                                 REST │  │ catálogo GraphQL / baja interna HTTP
                                      ▼  │
                                   REST Java ──MongoDB──> Aniflex_C
```

- GraphQL es la entrada de los clientes y administra series y episodios.
- REST administra estudios y la pertenencia de cada serie a un único estudio.
- Ningún servicio consulta ni escribe la base del otro. Cada uno usa un solo
  `MongoClient` de aplicación y su propia configuración de base de datos.
- REST consulta `seriesPorIds` en GraphQL para validar que las series existen y
  devolver sus datos actuales. Esa consulta no pide relaciones de estudios,
  por lo que no genera una llamada circular.
- GraphQL delega el CRUD de estudios en REST. El campo `Serie.estudioId` se
  obtiene consultando REST: no se guarda una copia en `Aniflex_AB`.
- Para borrar una serie, GraphQL pide a REST comprobar su pertenencia. REST
  mantiene la coordinación de las asociaciones mientras solicita por HTTP la
  baja local a GraphQL, que elimina la serie y sus episodios en `Aniflex_AB`.
  Así una asociación no puede intercalarse entre la comprobación y la baja
  en la instancia REST del prototipo.

El endpoint interno de baja exige `X-Aniflex-Interno`. Ambos servicios comparten
`ANIFLEX_INTEGRACION_CLAVE`; su valor predeterminado sirve para la ejecución local.
Los servidores escuchan únicamente en loopback. Para trabajar con relaciones y
bajas de series deben estar encendidos los dos servicios. Un fallo de comunicación
se informa al cliente; no se interpreta como ausencia de relaciones.

## Identificadores y relaciones

| Campo BSON | Uso |
| --- | --- |
| `_id` (ObjectId) | Identificador interno generado automáticamente. |
| `id` (string) | ID ingresado por el usuario, único por colección y editable. |

El contrato existente conserva `id` para el ObjectId interno y `codigo` para el
ID ingresado por el usuario. Los valores de `codigo` se normalizan a mayúsculas.
Las mutaciones y los dos clientes mantienen ese contrato.

`Aniflex_AB.series` y `Aniflex_AB.episodios` guardan sus propios documentos; el
episodio referencia a su serie por ObjectId. `Aniflex_C.estudios.SeriesIds` guarda
los ObjectId de las series de GraphQL. El índice multikey único de esa lista
impide que una serie pertenezca a dos estudios. Esta es una referencia entre
servicios, no una llave foránea impuesta por MongoDB entre bases.

Buscar un estudio devuelve `seriesIds` y los objetos `series` referenciados.
Las series no se duplican en `Aniflex_C`. Retirar o eliminar un estudio libera
sus referencias y conserva las series. Una serie asociada no puede eliminarse
hasta retirarla de su estudio.

## Organización

```text
servicio-rest/
  src/main/java/com/aniflex/rest/
    config/        MongoDB y ciclo de limpieza del prototipo
    model/         Estudio
    dto/           Entradas y respuestas HTTP
    repository/    Persistencia de estudios y relaciones en Aniflex_C
    integracion/   Cliente HTTP del catálogo de GraphQL
    service/       Validación y coordinación de asociaciones y bajas
    controller/    Endpoints REST
    exception/     Errores HTTP
aniflexprototipo3/  GraphQL, catálogo y persistencia en Aniflex_AB
cliente-.NET/       WinForms
cliente-react/      React
```

REST usa Spring Web MVC y el driver síncrono de MongoDB. Cada servidor tiene su
propio proyecto Maven y no importa clases del otro.

## Configuración

| Configuración | Valor por defecto |
| --- | --- |
| MongoDB REST | `servicio-rest/src/main/resources/application.properties`: base `Aniflex_C` |
| MongoDB GraphQL | `aniflexprototipo3/src/main/resources/application.properties`: base `Aniflex_AB` |
| REST consumido por GraphQL | `ANIFLEX_REST_URL=http://localhost:8081` |
| GraphQL consumido por REST | `ANIFLEX_GRAPHQL_URL=http://localhost:8080` (URL base, sin `/graphql`) |
| GraphQL consumido por WinForms | `ANIFLEX_GRAPHQL_URL=http://localhost:8080/graphql` (en el proceso del cliente) |
| GraphQL consumido por React | Proxy Vite hacia `http://localhost:8080/graphql` |
| Limpieza en cada servicio | `aniflex.prototipo.limpiar=true` |

Los parámetros Spring se pueden sobrescribir al ejecutar Maven; usa nombres de
base distintos para cada servicio. Ejemplo para GraphQL:

```powershell
.\mvnw.cmd spring-boot:run '-Dspring-boot.run.arguments=--aniflex.mongodb.database=Aniflex_AB_Pruebas'
```

Para REST utiliza `Aniflex_C_Pruebas` en el comando equivalente.

## Endpoints REST

| Método y ruta | Operación |
| --- | --- |
| `GET /api/estudios/` | Lista; filtros `codigo`, `paisOrigen`, `serieId` (ObjectId). |
| `GET /api/estudios/por-codigo/{codigo}` | Busca por ID del usuario. |
| `POST /api/estudios/` | Crea un estudio. |
| `PUT /api/estudios/{id}` | Actualiza por ObjectId. |
| `DELETE /api/estudios/{id}` | Elimina el estudio y sus referencias. |
| `DELETE /api/series/{id}` | Coordina la baja del catálogo de GraphQL; rechaza series asociadas. |

POST y PUT reciben `codigo`, `nombre`, `paisOrigen`, `fechaFundacion` (`yyyy-MM-dd`)
y `seriesIds`. Las respuestas incluyen el ObjectId `id` y las series referenciadas.
Los errores usan Problem Details: 400 para datos inválidos, 404 para actualización
de un estudio ausente, 409 para duplicados y 503 si MongoDB o GraphQL no están disponibles.
