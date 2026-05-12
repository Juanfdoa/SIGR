# SIGR — Sistema Integral de Gestión de Restaurante

Aplicación web full-stack para la administración operativa de restaurantes.
Gestiona pedidos, reservas, menú digital, control de caja y reportes.

> Proyecto académico — Gestión del Software · Tecnológica del Oriente · 2026

---

## Tecnologías

| Capa | Tecnología | Versión |
|---|---|---|
| Backend | ASP.NET Core Web API | 8.0 LTS |
| Frontend | React + Vite | 18.x |
| Base de datos | PostgreSQL | 16.x |
| ORM | Entity Framework Core | 8.0 |
| Autenticación | JWT Bearer | — |

## Estructura del Proyecto

```
sigr/
├── 01_Backend/       # API REST en ASP.NET Core 8
├── 02_Frontend/      # SPA en React 18
├── 03_Database/      # Scripts SQL y migraciones
├── 04_Docs/          # Documentación técnica
├── .gitignore
├── CHANGELOG.md
├── LICENSE
└── README.md
```

## Requisitos Previos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Node.js 20 LTS](https://nodejs.org/)
- [PostgreSQL 16](https://www.postgresql.org/download/)
- [Git 2.x](https://git-scm.com/)

## Instalación

### 1. Clonar el repositorio
```bash
git clone https://github.com/<usuario>/sigr.git
cd sigr
```

### 2. Base de datos
- Crear una base de datos llamada `sigr_db` en PostgreSQL
- Ejecutar los scripts ubicados en `03_Database/`
- Configurar la cadena de conexión en `01_Backend/appsettings.json`

### 3. Backend
```bash
cd 01_Backend
dotnet restore
dotnet run
```

### 4. Frontend
```bash
cd 02_Frontend
npm install
npm run dev
```

## Módulos del Sistema

| Módulo | Descripción |
|---|---|
| Auth | Registro, login y control de roles |
| Menú | Gestión de platos y categorías |
| Pedidos | Creación y seguimiento de pedidos por mesa |
| Reservas | Registro y disponibilidad de mesas |
| Caja | Cierre de caja y reportes de ventas |

## Documentación

| Documento | Ubicación |
|---|---|
| Arquitectura del sistema | `04_Docs/ARCHITECTURE.md` |
| Requerimientos | `04_Docs/REQUIREMENTS.md` |
| Historial de cambios | `CHANGELOG.md` |
| Línea base v1.0 | `04_Docs/` |

## Línea Base

Versión **v1.0** — establece el punto de control inicial del proyecto con la estructura del repositorio, módulos funcionales identificados y stack tecnológico definido.

---

**Autor:** Juan Fernando Acevedo Patiño  
**Docente:** Helio Ruber López Carreño  
**Institución:** Tecnológica del Oriente