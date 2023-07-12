# DiagramaNetCore
Voy a realizar un ejercicio de NetCore con el objetivo de mejorar mi rapidez a la hora de codificar.




## Documentacion
**Comandos utilizados para la creacion de mi proyecto (La estructura o Base del proyecto)**

```Terminal
1. dotnet new sln                                                                                       ---> Crea una nueva solución de .NET.
---(Una solución (.sln) se refiere a un archivo que actúa como un contenedor para organizar y administrar proyectos relacionados en un entorno de desarrollo de .NET)


2. dotnet new webapi -o API                                                                             ---> Crea un nuevo proyecto de API web en la carpeta "API".

3. dotnet sln add API/                                                                                  ---> Agrega el proyecto "API" a la solución.

4. dotnet new classlib -o Core                                                                          ---> Crea un nuevo proyecto de biblioteca de clases en la carpeta "Core".

5. dotnet new classlib -o Infraestructure                                                               ---> Crea un nuevo proyecto de biblioteca de clases en la carpeta "Infraestructure".

6. dotnet sln add Core/                                                                                 ---> Agrega el proyecto "Core" a la solución.

7. dotnet sln add Infraestructure/                                                                      ---> Agrega el proyecto "Infraestructure" a la solución.


8. cd Infraestructure/
    - dotnet add reference ../Core/                                                                     ---> Agrega una referencia al proyecto "Core" desde el proyecto "Infraestructure".


9. cd API/
    - dotnet add reference ../Infraestructure/                                                          ---> Agrega una referencia al proyecto "Infraestructure" desde el proyecto "API".


9. cd Infraestructure/
    - dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0-preview.5.23280.1                ---> Agrega el paquete de Entity Framework Core versión 8.0.0-preview.5.23280.1 al proyecto "Infraestructure".
    - dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0                               ---> Agrega el paquete de Entity Framework Core para MySQL versión 7.0.0 al proyecto "Infraestructure".


10. cd API/
    - dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.8                           ---> Agrega el paquete de diseño de Entity Framework Core versión 7.0.8 al proyecto "API".


11. dotnet tool list -g                                                                                 ---> Lista las herramientas globales instaladas en .NET.

```

---
>ESTO ES IMPORTANTE
> - **Migrations** (Se deben utilizar estos comandos para poder aplicar las migraciones y que los cambios se guarden en la base de datos)
>   - dotnet ef migrations add InitialCreate --project./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations
>   - dotnet ef database update --project ./Infrastructure/ --startup-project ./API/