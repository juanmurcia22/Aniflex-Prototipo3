# Servicio REST Java

Consulta el [README principal](../README.md) para iniciar todos los procesos localmente.

Este servicio administra estudios y relaciones en `Aniflex_C`. Consulta las series
por HTTP al servicio GraphQL, dueño de `Aniflex_AB`; nunca abre esa base.

Paquetes: `config`, `model`, `dto`, `repository`, `integracion`, `service`,
`controller` y `exception`. El modo desechable vacía las colecciones propias al
iniciar y detener Spring; está activado por defecto.
