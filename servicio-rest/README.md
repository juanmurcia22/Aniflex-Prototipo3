# Servicio REST Java de estudios

API Spring Boot independiente en el puerto 8081, organizada en los paquetes
`config`, `model`, `dto`, `repository`, `service`, `controller` y `exception`.
Sus dependencias de producción son Spring Web MVC y el driver síncrono de MongoDB.

Los pasos completos de arranque, las responsabilidades, el contrato HTTP
y la configuración local están en el [README principal](../README.md).

Desde esta carpeta se inicia con `./mvnw.cmd spring-boot:run` en Windows,
o `sh ./mvnw spring-boot:run` en Linux/macOS.
