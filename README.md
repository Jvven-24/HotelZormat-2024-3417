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
HotelZormat.UI (Windows Forms)
↓
HotelZormat.Negocio (Servicios, reglas de negocio, excepciones)
↓
HotelZormat.Datos (Repositorios ADO.NET, conexión a BD)
↓
HotelZormat.Modelo (Clases de dominio puras)

La UI **no** referencia a Datos directamente — solo pasa por Negocio.
## Módulos incluidos
- Login con roles (Administrador / Recepcionista) y control de acceso por pantalla
- CRUD de Habitaciones (filtros por piso/estado, colores por estado)
- CRUD de Huéspedes (validación de cédula/pasaporte según tipo de documento)
- Reservas (cálculo de tarifa según temporada, validación de disponibilidad)
- Check-in / Check-out con generación de factura y NCF secuencial
- Gestión de Usuarios (alta/baja, contraseña con hash SHA-256)
- Reportes (ocupación del día, ingresos por rango de fechas)
- Bitácora de auditoría (registro y filtro por acción)
## Cómo restaurar la base de datos
1. Abrir SSMS y conectarse a la instancia local (`.` o la que tengas configurada).
2. Ejecutar el script completo `script_bd.sql` (raíz del repo). Crea la base `HotelZormatDB`, todas las tablas y los datos semilla (usuarios, 9 habitaciones, 2 huéspedes de prueba).
3. Verificar con: `SELECT * FROM Habitaciones WHERE Piso = 3 ORDER BY Numero;` — debe devolver 4 filas.
## Configuración de conexión
El `App.config` está en el proyecto `HotelZormat.UI` (es el proyecto de inicio — `ConfigurationManager` siempre lee el `App.config` del ejecutable).
Cadena de conexión usada (ajustar el `Data Source` si tu instancia de SQL Server tiene otro nombre, por ejemplo `.\SQLEXPRESS`):
```xml
<connectionStrings>
    <add name="HotelZormatDB"
         connectionString="Server=.;Database=HotelZormatDB;Integrated Security=True;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
Se lee de forma centralizada desde HotelZormat.Datos/Conexion/ConfiguracionBD.cs.

Usuarios de prueba
Usuario	Contraseña	Rol
admin	Admin123	Administrador
recepcion	Recep123	Recepcionista
Las contraseñas se almacenan con hash SHA-256 (Usuarios.Contrasena), nunca en texto plano.
