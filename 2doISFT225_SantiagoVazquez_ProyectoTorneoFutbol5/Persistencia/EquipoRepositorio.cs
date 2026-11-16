using MySql.Data.MySqlClient;
using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia
{
    public class EquipoRepositorio
    {
        public List<Equipo> ObtenerTodos()
        {
            List<Equipo> equipos = new List<Equipo>();

            using MySqlConnection conexion = new MySqlConnection(Conexion.CadenaConexion);
            conexion.Open();

            // COUNT de las inscripciones de cada equipo = cuántos jugadores tiene.
            const string sql =
                "SELECT e.id_equipo, e.nombre_equipo, e.id_categoria, e.id_capitan, " +
                "       COUNT(i.num_inscripcion) AS cantidad " +
                "FROM equipos e " +
                "LEFT JOIN inscripciones i ON i.id_equipo = e.id_equipo " +
                "GROUP BY e.id_equipo, e.nombre_equipo, e.id_categoria, e.id_capitan " +
                "ORDER BY e.nombre_equipo;";

            using MySqlCommand comando = new MySqlCommand(sql, conexion);
            using MySqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                equipos.Add(new Equipo
                {
                    Id = lector.GetInt32("id_equipo"),
                    Nombre = lector.GetString("nombre_equipo"),
                    IdCategoria = lector.GetInt32("id_categoria"),
                    IdCapitan = lector.GetInt32("id_capitan"),
                    CantidadJugadores = lector.GetInt32("cantidad"),
                });
            }

            return equipos;
        }

        // Crea el equipo y anota al capitán como su primer jugador, en una transacción.
        public void Insertar(Equipo equipo, Inscripcion capitan)
        {
            using MySqlConnection conexion = new MySqlConnection(Conexion.CadenaConexion);
            conexion.Open();
            using MySqlTransaction transaccion = conexion.BeginTransaction();

            const string sqlEquipo =
                "INSERT INTO equipos (nombre_equipo, id_categoria, id_capitan) " +
                "VALUES (@nombre, @categoria, @capitan); " +
                "SELECT LAST_INSERT_ID();";

            using (MySqlCommand comando = new MySqlCommand(sqlEquipo, conexion, transaccion))
            {
                comando.Parameters.AddWithValue("@nombre", equipo.Nombre);
                comando.Parameters.AddWithValue("@categoria", equipo.IdCategoria);
                comando.Parameters.AddWithValue("@capitan", equipo.IdCapitan);
                equipo.Id = Convert.ToInt32(comando.ExecuteScalar());
            }

            using (MySqlCommand comando = new MySqlCommand(
                "UPDATE inscripciones SET id_equipo = @equipo WHERE num_inscripcion = @numero;",
                conexion, transaccion))
            {
                comando.Parameters.AddWithValue("@equipo", equipo.Id);
                comando.Parameters.AddWithValue("@numero", capitan.Numero);
                comando.ExecuteNonQuery();
            }

            transaccion.Commit();
            equipo.CantidadJugadores = 1;
        }

        // Sin distinguir mayúsculas: "Los Tigres" y "los tigres" cuentan como el mismo nombre.
        public bool ExisteNombre(string nombre)
        {
            using MySqlConnection conexion = new MySqlConnection(Conexion.CadenaConexion);
            conexion.Open();

            const string sql = "SELECT COUNT(*) FROM equipos WHERE LOWER(nombre_equipo) = LOWER(@nombre);";

            using MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", nombre);

            return Convert.ToInt32(comando.ExecuteScalar()) > 0;
        }

        public int ContarJugadores(int idEquipo)
        {
            using MySqlConnection conexion = new MySqlConnection(Conexion.CadenaConexion);
            conexion.Open();

            const string sql = "SELECT COUNT(*) FROM inscripciones WHERE id_equipo = @equipo;";

            using MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@equipo", idEquipo);

            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}
