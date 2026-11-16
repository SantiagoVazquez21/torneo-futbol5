using MySql.Data.MySqlClient;
using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia
{
    // Única puerta de la Lógica hacia la base: la Controladora no conoce los
    // repositorios ni el SQL, solo llama a estos métodos.
    public class ControladoraPersistencia
    {
        private readonly InscripcionRepositorio inscripcionRepositorio = new InscripcionRepositorio();
        private readonly CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();

        public List<Categoria> TraerCategorias()
        {
            return Ejecutar(() => categoriaRepositorio.ObtenerTodas());
        }

        public List<Inscripcion> TraerInscripciones()
        {
            return Ejecutar(() => inscripcionRepositorio.ObtenerTodas());
        }

        public void CrearInscripcion(Inscripcion inscripcion)
        {
            Ejecutar(() => inscripcionRepositorio.Insertar(inscripcion));
        }

        public void EditarInscripcion(Inscripcion inscripcion)
        {
            Ejecutar(() => inscripcionRepositorio.Actualizar(inscripcion));
        }

        public void EliminarInscripcion(Inscripcion inscripcion)
        {
            Ejecutar(() => inscripcionRepositorio.Eliminar(inscripcion));
        }

        public bool ExisteDni(string dni, int idParticipanteExcluido)
        {
            return Ejecutar(() => inscripcionRepositorio.ExisteDni(dni, idParticipanteExcluido));
        }

        // Corre la operación y, si MySQL falla, la convierte en PersistenciaException.
        // Así el try/catch está escrito una sola vez y no en cada método.
        private static T Ejecutar<T>(Func<T> operacion)
        {
            try
            {
                return operacion();
            }
            catch (MySqlException ex)
            {
                throw new PersistenciaException(ex);
            }
        }

        private static void Ejecutar(Action operacion)
        {
            try
            {
                operacion();
            }
            catch (MySqlException ex)
            {
                throw new PersistenciaException(ex);
            }
        }
    }
}
