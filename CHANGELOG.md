# CHANGELOG

Todos los cambios relevantes del proyecto SIGR se documentan en este archivo.
El formato está basado en [Keep a Changelog](https://keepachangelog.com/es/1.0.0/).

---

## [v1.0.0] — 2026-05-07 · Línea Base Inicial

### Agregado
- Estructura inicial del repositorio con carpetas `01_Backend`, `02_Frontend`, `03_Database`, `04_Docs` y `.gitignore`
- Proyecto ASP.NET Core 8 Web API en `01_Backend/`
- Proyecto React 18 + Vite en `02_Frontend/`
- Configuración de conexión a PostgreSQL 16 con Entity Framework Core 8
- Scripts SQL iniciales de esquema de base de datos en `03_Database/`
- Módulo de autenticación con JWT Bearer (register y login)
- Documentación técnica inicial: `requierements.md` y `architecture.md` en `04_Docs/`
- Archivos base del repositorio: `README.md`, `CHANGELOG.md`, `LICENSE`, 
- Línea base v1.0 documentada en `04_Docs/`

### Configurado
- Convención de commits basada en [Conventional Commits](https://www.conventionalcommits.org/)
- Estrategia de ramas: `main` (producción) y `dev` (desarrollo)

---

*Próxima versión:* `v1.1.0` — Implementación de módulo de menú y pedidos.