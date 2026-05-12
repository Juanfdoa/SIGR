# Arquitectura SIGR

## Visión General
┌─────────────────────────────────────────┐
│              Cliente / Browser           │
└────────────────────┬────────────────────┘
│ HTTP / HTTPS
┌────────────────────▼────────────────────┐
│           Frontend (React 18)            │
│         Vite · React Router · Axios      │
└────────────────────┬────────────────────┘
│ REST API (JSON)
┌────────────────────▼────────────────────┐
│         Backend (ASP.NET Core 8)         │
│   Controllers · Services · Middleware    │
│         Autenticación JWT Bearer         │
└──────────┬─────────────────┬────────────┘
│ EF Core 8       │
┌──────────▼─────────────────▼────────────┐
│           PostgreSQL 16                  │
│     Esquema relacional · Migraciones     │
└─────────────────────────────────────────┘

## Capas del Sistema

### Frontend — React 18
- Interfaz de usuario (SPA)
- Consumo de la API REST mediante Axios
- Manejo de rutas con React Router
- Gestión de sesión mediante token JWT en memoria

### Backend — ASP.NET Core 8
- API REST con controladores por módulo
- Lógica de negocio en capa de servicios
- Autenticación y autorización con JWT Bearer
- Acceso a datos mediante Entity Framework Core 8

### Base de Datos — PostgreSQL 16
- Persistencia relacional de todos los datos del sistema
- Migraciones gestionadas desde EF Core
- Scripts de esquema inicial en `03_Database/`

## Módulos

| Módulo | Responsabilidad |
|---|---|
| Auth | Registro, login y validación de roles |
| Menú | Gestión de platos y categorías |
| Pedidos | Creación y seguimiento de pedidos |
| Reservas | Registro y disponibilidad de mesas |
| Caja | Cierre de caja y reportes de ventas |

## Flujo de una Solicitud