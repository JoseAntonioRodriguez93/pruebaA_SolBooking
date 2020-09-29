# pruebaA_SolBooking
API catalogo de hoteles
### Instrucciones:

1º Descargar y abrir la solución.

2º En el archivo appsettings.json modificar los parametros de conexión para poder conectar con la base de datos, si es una base de datos local, solo hay que cambiar el nombre de la instancia de forma que quede así:

> "Conexion": "Server=localhost\\[NOMBRE DE LA INSTANCIA]; 

3º Acceder a la consola de administración de paquetes, e introducir el comando:

> update-database

4º Una vez realizado este proceso, se ha debido de crear la base de datos y las dos tablas que contienen la información de los hoteles. Introducir datos de ejemplo en la base de datos ejecutando este código (Se ha tomado como ID de los hoteles el propio nombre del hotel):

>USE [pruebaSolbookit]
>GO
>
>INSERT INTO [dbo].[CabeceraHotelItems]
>           ([Nombre]
>           ,[Categoria]
>           ,[Descripcion]
>           ,[Foto]
>           ,[Destacado])
>     VALUES
>           ('Barcelo', 4, 'Hotel de 4 estrellas', '[ruta]', 0), ('Miramar', 5, 'Hotel de 5 estrellas', '[ruta]', 1)
>GO
>
>INSERT INTO [dbo].[DetalleHotelItems]
>           ([Nombre]
>           ,[Ciudad]
>           ,[Descripcion]
>           ,[Imagen]
>           ,[Caracteristicas])
>     VALUES
>           ('Barcelo', 'Malaga', 'Hotel de 4 estrellas', '[ruta]', 'Amplio hotel frente a la estación'), ('Miramar', 'Malaga', 'Hotel de 5 estrellas', '[ruta]', 'Amplio hotel >frente a la playa')
>GO

5º Una vez hecho esto, ejecutar el IIS Express de Visual Studio para que se ejecute la API y realizar todas las peticiones del ejercicio a traves de Postman. 

Ejemplo: para obtener el detalle de un hotel concreto, introducir la ruta: https://localhost:44340/api/Hotels/[Nombre del hotel]
