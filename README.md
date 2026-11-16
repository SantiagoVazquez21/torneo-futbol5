# Torneo Fútbol 5 - Inscripciones

CRUD en C# Windows Forms (.NET 8) para inscribir participantes a un torneo de fútbol 5, con base de datos MySQL en la nube (TiDB Cloud).
La categoría se asigna automáticamente según la edad y el sexo del participante.
Los jugadores se pueden agrupar en equipos de hasta 5, cada uno con un capitán.

## Requisitos

- Visual Studio 2022 (versión 17.8 o superior) o Visual Studio 2026, con la carga de trabajo "Desarrollo de escritorio de .NET"
- .NET 8 (viene incluido en esa carga de trabajo)
- Acceso a la base en TiDB Cloud (o XAMPP para trabajar en local)

## Cómo ejecutarlo

1. En la carpeta del proyecto, copiar `conexion.ejemplo.txt` como `conexion.local.txt`.
2. Completar en `conexion.local.txt` el host, usuario y contraseña de TiDB (botón **Connect** del cluster).
3. Abrir `2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.sln` en Visual Studio y ejecutar.

`conexion.local.txt` está en el `.gitignore` porque contiene la contraseña: no se sube al repositorio.

### Trabajar en local con XAMPP

1. Iniciar MySQL desde el panel de XAMPP.
2. En phpMyAdmin: **Importar** → `BaseDeDatos/torneo_futbol5.sql` (crea la base con sus tablas y datos de ejemplo).
3. En `conexion.local.txt` usar la línea de XAMPP en lugar de la de TiDB.

Si la base se importó antes de que existieran los equipos, correr `BaseDeDatos/agregar_equipos.sql` para sumarlos.

## Equipos

- Se crean desde **Crear equipo**: se escribe el nombre y se elige al capitán entre los jugadores que no tienen equipo.
- El equipo juega en la categoría del capitán y admite hasta **5 jugadores** (contando al capitán).
- A un jugador se le asigna equipo al agregarlo o después, desde **Modificar jugador**. Elegir equipo no es obligatorio.
- El capitán no puede dejar su equipo. Si se lo elimina, el equipo se disuelve y sus jugadores quedan sin equipo.

## Estructura (modelo de 3 capas)

```
IGU/            Formularios: leen los datos y muestran mensajes
  FormPrincipal, FormJugador (alta y modificación), FormListado, FormEquipo,
  GrillaJugadores (tabla de jugadores que usan FormListado y FormEquipo)
Logica/         Reglas del torneo y modelo
  Controladora, Participante, Categoria, Inscripcion, Equipo, ValidacionException
Persistencia/   Acceso a la base de datos
  ControladoraPersistencia, InscripcionRepositorio, CategoriaRepositorio, EquipoRepositorio,
  Conexion, PersistenciaException
```

Cada capa solo habla con la siguiente: **IGU → Controladora → ControladoraPersistencia → Repositorios → BD**.

## Base de datos

| Tabla | Contenido |
|---|---|
| `participantes` | Datos personales de cada inscripto |
| `categorias` | Categorías del torneo con rango de edad y sexo |
| `inscripciones` | Une cada participante con su categoría y su equipo (`id_equipo` NULL = sin equipo); guarda fecha y si abonó |
| `equipos` | Nombre, categoría en la que juega y capitán |
