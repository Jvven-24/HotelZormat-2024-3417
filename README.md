# Hotel Zormat — Sistema de Gestión Hotelera

Práctica final · ISW-123

**Estudiante:** Jevenssen Martínez Martínez
**Matrícula:** 2024-3417

## Stack

- C# / .NET Framework 4.7.2
- Windows Forms (UI)
- SQL Server (ADO.NET puro, sin ORM)
- Arquitectura en 4 capas

## Arquitectura

```
HotelZormat.UI (Windows Forms)
        ↓
HotelZormat.Negocio (Servicios, reglas de negocio, excepciones)
        ↓
HotelZormat.Datos (Repositorios ADO.NET, conexión a BD)
        ↓
HotelZormat.Modelo (Clases de dominio puras)
```

La UI **no** referencia a Datos directamente — solo pasa por Negocio.

## Cómo restaurar la base de datos

1. Abrir SSMS y conectarse a la instancia local (`.\SQLEXPRESS` o la que tengas configurada).
2. Ejecutar el script completo `Cuero.sql` (raíz del repo). Crea la base `HotelZormatDB`, todas las tablas y los datos semilla (usuarios, 9 habitaciones, 2 huéspedes de prueba).
3. Verificar con: `SELECT * FROM Habitaciones WHERE Piso = 3 ORDER BY Numero;` — debe devolver 4 filas.

## Configuración de conexión

El `App.config` está en el proyecto `HotelZormat.UI` (es el proyecto de inicio — `ConfigurationManager` siempre lee el `App.config` del ejecutable).

Cadena de conexión usada (ajustar el `Data Source` si tu instancia de SQL Server tiene otro nombre):

```xml
<connectionStrings>
    <add name="HotelZormatDB"
         connectionString="Server=.\SQLEXPRESS;Database=HotelZormatDB;Integrated Security=True;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Se lee de forma centralizada desde `HotelZormat.Datos/Conexion/ConfiguracionBD.cs`.

## Usuarios de prueba

| Usuario | Contraseña | Rol |
|---|---|---|
| admin | Admin123 | Administrador |
| recepcion | Recep123 | Recepcionista |

## Checklist de módulos

- [x] Esqueleto: solución, 4 proyectos, referencias, BD, App.config
- [x] Clases del modelo
- [x] Interfaces de repositorios
- [x] Servicios base + `ReservaService` (lab Día 05) + `HabitacionOcupadaException`
- [ ] Forms de la UI (Día 2)
- [ ] Login y roles (Día 2)
- [ ] CRUD Habitaciones (Día 2)
- [ ] CRUD Huéspedes y Reservas (Día 3)
- [ ] Check-in / Check-out y facturación (Día 4)
- [ ] Reportes y bitácora (Día 4)
```

