using MySql.Data.MySqlClient;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia
{
    // No se pudo leer o guardar en la base (sin internet, credenciales mal, etc.).
    // Envuelve el error de MySQL para que las otras capas no dependan de MySql.Data.
    public class PersistenciaException : Exception
    {
        public PersistenciaException(MySqlException error)
            : base("No se pudo acceder a la base de datos.\n\n" +
                   "Verificá la conexión a internet y el archivo conexion.local.txt.\n\n" +
                   $"Detalle: {error.Message}", error)
        {
        }
    }
}
