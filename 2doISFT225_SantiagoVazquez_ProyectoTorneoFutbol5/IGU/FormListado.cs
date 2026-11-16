using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;
using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    public partial class FormListado : Form
    {
        private readonly Controladora controladora = new Controladora();

        public FormListado()
        {
            InitializeComponent();

            CargarInscripciones();
        }

        // Se vuelve a leer todo de la base después de cada cambio: así la tabla
        // muestra siempre lo que realmente quedó guardado.
        private void CargarInscripciones()
        {
            try
            {
                grillaJugadores.Cargar(controladora.TraerInscripciones());
            }
            catch (PersistenciaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Inscripcion? InscripcionSeleccionada()
        {
            Inscripcion? seleccionada = grillaJugadores.Seleccionada;

            if (seleccionada == null)
            {
                MessageBox.Show("Seleccione una inscripción de la tabla.");
            }

            return seleccionada;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Inscripcion? seleccionada = InscripcionSeleccionada();

            if (seleccionada == null)
            {
                return;
            }

            using FormJugador formJugador = new FormJugador(seleccionada);

            // Solo se recarga si se guardó; si canceló, no cambió nada.
            if (formJugador.ShowDialog(this) == DialogResult.OK)
            {
                CargarInscripciones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Inscripcion? seleccionada = InscripcionSeleccionada();

            if (seleccionada == null)
            {
                return;
            }

            string pregunta = $"¿Está seguro de eliminar a {seleccionada.Participante}?";

            if (seleccionada.EsCapitan)
            {
                pregunta += $"\n\nEs capitán de {seleccionada.Equipo!.Nombre}: el equipo se va a disolver " +
                            "y sus jugadores van a quedar sin equipo.";
            }

            DialogResult respuesta = MessageBox.Show(
                pregunta,
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                controladora.EliminarJugador(seleccionada);
            }
            catch (PersistenciaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CargarInscripciones();

            MessageBox.Show("Jugador eliminado correctamente.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grillaJugadores_JugadorDobleClic(object? sender, EventArgs e)
        {
            btnModificar_Click(this, EventArgs.Empty);
        }

        private void FormListado_Shown(object sender, EventArgs e)
        {
            grillaJugadores.LimpiarSeleccion();
        }
    }
}
