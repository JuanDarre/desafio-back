# Sistema de Gestión CRUD

Este proyecto es un sistema de gestión CRUD desarrollado en Angular con C# y una base de datos SQL Server. Permite realizar operaciones básicas de creación, lectura, actualización y eliminación de registros.

## Funcionalidades

- **Registro de Clientes:** Los clientes pueden registrarse en el sistema proporcionando su información básica, como nombre, identificación, edad, género, etc.

- **Base de Datos SQL Server:** La información de los clientes y otros datos relevantes se almacenan en una base de datos SQL Server para garantizar la persistencia y la integridad de los datos.

## Requisitos del Sistema

- Angular
- C#
- SQL Server
- .Net 6

## Instalación y Configuración

1. Clona este repositorio en tu PC.
2. Abre el proyecto en Visual Studio.
3. Configura la cadena de conexión a la base de datos en el archivo `appsettings.json`.
4. Abre una nueva terminal y escribe los siguientes comandos para levantar una nueva base de datos:
   ```bash
   Add-Migration initial
   Update-Database
