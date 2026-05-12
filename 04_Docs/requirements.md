# Requerimientos del Proyecto SIGR

## Backend
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [PostgreSQL 16](https://www.postgresql.org/download/)
- [Entity Framework Core 8](https://learn.microsoft.com/en-us/ef/core/)

## Frontend
- [Node.js 20 LTS](https://nodejs.org/)
- [React 18](https://react.dev/)
- [Vite](https://vitejs.dev/) *(bundler)*

## Herramientas
- [Git 2.x](https://git-scm.com/)
- [GitHub](https://github.com/) *(repositorio remoto)*
- [Visual Studio 2022](https://visualstudio.microsoft.com/) *(backend)*
- [Visual Studio Code](https://code.visualstudio.com/) *(frontend)*
- [pgAdmin 4](https://www.pgadmin.org/) *(administración de base de datos)*
- [Postman](https://www.postman.com/) *(pruebas de API)*

## Instalación rápida

### 1. Clonar el repositorio
```bash
git clone https://github.com/Juanfdoa/SIGR
```

### 2. Backend
```bash
cd 01_Backend
dotnet restore
dotnet run
```

### 3. Frontend
```bash
cd 02_Frontend
npm install
npm run dev
```

### 4. Base de datos
- Crear una base de datos en PostgreSQL llamada `sigr_db`
- Ejecutar los scripts ubicados en `03_Database/`
- Configurar la cadena de conexión en `01_Backend/appsettings.json`