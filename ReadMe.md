# CRUD .Net Web Rest API

Proyecto introductorio de creación de **Rest APi** en [.Net](https://dotnet.microsoft.com/es-es/) usando editor de código:

- [VisualStudioCode](https://code.visualstudio.com)

## Útiles

> [!IMPORTANT]
> Para iniciar el servicio se deben ejecutar los siguientes comandos en el orden dado

| Comando                             | Descripción                                                                                                                           |
| ----------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
| `cd WebAPIProducto`                 | Acceder a la carpeta del proyecto.                                                                                                    |
| `dotnet ef migrations add {nombre}` | Migra la base de Datos con el `{nombre}` especificado en caso de haber modificado algo, sino hay cambios, no se ejecuta este comando. |
| `dotnet ef database update`         | Genera el archivo de Base de Datos en función del DMBS escogido.                                                                      |
| `dotnet run`                        | Inicializa el servicio.                                                                                                               |
