# Aniflex

Aplicación de estudios de animación, series y episodios con cliente WinForms,
servidor GraphQL Java, servicio REST Java y MongoDB local.

## Iniciar el proyecto en Windows

Se requiere JDK 21 o superior con `JAVA_HOME` configurado, MongoDB Community
y SDK .NET 10. Los servidores incluyen Maven Wrapper. La primera ejecución
descarga Maven y las dependencias. Node.js y npm se requieren para usar React.

Abre las terminales en la raíz del repositorio. Mantén una terminal abierta
por cada proceso, siguiendo este orden.

### 1. MongoDB local

Inicia el servicio MongoDB de Windows. La conexión por defecto es
`mongodb://localhost:27017` y la base de datos es `Aniflex`.
Puedes inspeccionarla desde MongoDB Compass con esa misma dirección.

### 2. Servicio REST Java — puerto 8081

```powershell
Set-Location .\servicio-rest
.\mvnw.cmd spring-boot:run
```

Espera a que el registro muestre que el servidor inició en el puerto 8081.
Comprueba el servicio en otra terminal con esta consulta. Una lista vacía
es una respuesta válida cuando todavía no hay estudios.

```powershell
Invoke-RestMethod http://localhost:8081/api/estudios/
```

### 3. Servidor GraphQL Java — puerto 8080

En otra terminal, desde la raíz del repositorio:

```powershell
Set-Location .\aniflexprototipo3
.\mvnw.cmd spring-boot:run
```

Abre [GraphiQL](http://localhost:8080/graphiql) y ejecuta:

```graphql
query {
  listarSeries { id titulo }
  listarEstudios { id codigo nombre }
}
```

### 4. Cliente WinForms .NET

En otra terminal, desde la raíz del repositorio:

```powershell
dotnet run --project .\cliente-.NET\Aniflex.Client\Aniflex.Client.csproj
```

El menú Estudios permite listar, agregar, buscar, actualizar y eliminar.
Los listados se abren vacíos. Pulsa Cargar para obtener todo el contenido,
o Filtrar para aplicar los criterios. Limpiar borra los filtros y la grilla.
La búsqueda individual usa el ID manual de cada entidad. Al crear o editar
un estudio, ingresa el ID manual de una serie y pulsa Añadir serie. La lista
muestra únicamente las series seleccionadas, con su ID manual y título.
Desde el listado de series,
el botón Ver estudios muestra los estudios asociados a la fila seleccionada.

### Cliente React opcional

En otra terminal, desde la raíz del repositorio:

```powershell
Set-Location .\cliente-react
npm ci
npm run dev
```

React consume el contrato GraphQL de series y episodios. Los formularios
de estudios están implementados en WinForms.

Para detener los servidores y React, pulsa `Ctrl+C` en sus terminales.

## Responsabilidades de los servicios

| Componente | Responsabilidad |
| --- | --- |
| WinForms | Formularios del CRUD y selección de las relaciones. |
| GraphQL Java, puerto 8080 | Contrato de los clientes, operaciones de series y episodios y consultas combinadas con estudios. Delega los estudios y las bajas de series a REST. |
| REST Java, puerto 8081 | CRUD de estudios, validación de códigos y referencias, y bajas de series con sus episodios. |
| MongoDB local, puerto 27017 | Persistencia de `estudios`, `series` y `episodios` en la base `Aniflex`. |

Las operaciones de estudios recorren cliente → GraphQL → REST → MongoDB.
Las consultas y altas/modificaciones de series y episodios recorren
cliente → GraphQL → MongoDB. La eliminación de series pasa por REST para
coordinarla con las asociaciones de estudios.

## Organización del repositorio

```text
servicio-rest/         API REST Java independiente (Maven / Spring Boot)
  src/main/java/com/aniflex/rest/
    config/           Configuración de MongoDB
    model/            Modelo Estudio
    dto/              Datos de entrada y respuesta HTTP
    repository/       Lectura y escritura de documentos MongoDB
    service/          Validaciones y coordinación de operaciones
    controller/       Endpoints HTTP
    exception/        Conversión de errores a respuestas HTTP
aniflexprototipo3/    Servidor GraphQL Java
cliente-.NET/         Cliente WinForms
cliente-react/        Cliente React
```

REST usa Spring Web MVC y el driver síncrono de MongoDB. Se comunica con
GraphQL mediante HTTP. Cada servidor tiene su propio proyecto Maven.

## Modelo de Estudio y relaciones

Las tres entidades tienen dos identificadores en MongoDB.

| Campo BSON | Uso |
| --- | --- |
| `_id` (ObjectId) | Identificador interno único generado automáticamente. |
| `id` (string) | ID manual obligatorio, único dentro de cada colección y editable por el usuario. |

En el contrato HTTP/GraphQL existente, `id` transporta el ObjectId interno
y `codigo` transporta el ID manual. Los formularios distinguen ObjectId de
ID manual. Las búsquedas de series y episodios usan `buscarSeriePorCodigo`
y `buscarEpisodioPorCodigo`. Los índices únicos de MongoDB impiden repetir
un ID manual. Los valores se normalizan a mayúsculas.

La relación es de un estudio a varias series. Una serie puede estar libre
o asociada a un único estudio. El estudio guarda los ObjectId en `SeriesIds`
y cada serie asociada guarda `estudioId` como ObjectId. Un índice multikey
único en `estudios.SeriesIds` impide que otra escritura reclame esa misma
serie para otro estudio. REST comprueba esa regla antes de guardar.

Al buscar un estudio, REST y GraphQL devuelven tanto `seriesIds` como
`series`, la lista de objetos Serie referenciados. WinForms muestra estos
objetos directamente. Retirar una serie del estudio elimina su `estudioId`.
Borrar un estudio conserva sus series y limpia sus referencias. Para
borrar una serie, primero hay que retirar su asociación con el estudio.

REST coordina las escrituras de asociaciones en una instancia local.
El arranque y las consultas reparan las referencias de una operación
interrumpida a partir de las asociaciones únicas guardadas en el estudio.
Las ediciones de series actualizan solo sus atributos editables para
conservar la asociación incluso si se cambia al mismo tiempo.

### Documentos de versiones anteriores

Al iniciar GraphQL, los documentos que carecen de ID manual reciben
`SER-<ObjectId>` o `EPI-<ObjectId>`, sin cambiar su ObjectId ni sus relaciones.
Esos IDs de transición se pueden editar desde Actualizar. Los registros
nuevos requieren el ID ingresado por el usuario. REST conserva el ID manual
de los estudios anteriores, trasladándolo de `Codigo` al campo BSON `id`,
y reconstruye `series.estudioId` a partir de sus `SeriesIds`.

Si los datos anteriores vinculan la misma serie a varios estudios, REST
informa el conflicto al iniciar para que se resuelva la pertenencia de esa
serie. La migración conserva los documentos y sus ObjectId.

## Configuración local

| Configuración | Archivo o variable |
| --- | --- |
| MongoDB de REST | `servicio-rest/src/main/resources/application.properties` |
| MongoDB de GraphQL y carga de ejemplos | `aniflexprototipo3/src/main/resources/application.properties` |
| URL REST consumida por GraphQL | `ANIFLEX_REST_URL`, por defecto `http://localhost:8081` |
| URL GraphQL consumida por WinForms | `ANIFLEX_GRAPHQL_URL`, por defecto `http://localhost:8080/graphql` |

Ambos servidores deben apuntar a la misma base. Para ejecutar con una base
de pruebas, agrega a cada comando de Maven:

```powershell
.\mvnw.cmd spring-boot:run '-Dspring-boot.run.arguments=--aniflex.mongodb.database=Aniflex_Pruebas'
```

GraphQL carga ejemplos si las colecciones están vacías. Para trabajar con
tus propios datos, configura `aniflex.datos-iniciales=false` en su archivo
`application.properties`.

## Endpoints REST

| Método y ruta | Operación |
| --- | --- |
| `GET /api/estudios/` | Lista y filtra con `codigo`, `paisOrigen` y `serieId`. |
| `GET /api/estudios/por-codigo/{codigo}` | Busca por código manual. |
| `POST /api/estudios/` | Crea un estudio y genera su ObjectId. |
| `PUT /api/estudios/{id}` | Actualiza por ObjectId interno. |
| `DELETE /api/estudios/{id}` | Elimina el estudio. |
| `DELETE /api/series/{id}` | Comprueba asociaciones y elimina la serie con sus episodios. |

POST y PUT reciben `codigo`, `nombre`, `paisOrigen`, `fechaFundacion`
(por ejemplo `2000-01-01`) y `seriesIds` (un arreglo de IDs en texto).
La respuesta incluye el `id` interno. Los errores usan Problem Details
con HTTP 400 para datos inválidos, 404 para una actualización de un estudio
ausente, 409 para código duplicado y 503 para fallos de MongoDB.

Ejemplo para GraphiQL:

```graphql
mutation {
  adicionarEstudio(input: {
    codigo: "EST-001", nombre: "MAPPA", paisOrigen: "Japón",
    fechaFundacion: "2011-06-14", seriesIds: []
  }) { id codigo nombre }
}
```
