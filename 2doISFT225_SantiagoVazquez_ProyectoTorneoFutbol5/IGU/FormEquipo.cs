using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;
using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    // Crear un equipo: se escribe el nombre y se elige al capitán en la tabla.
    public partial class FormEquipo : Form
    {
        private readonly Controladora controladora = new Controladora();

        public FormEquipo()
        {
            InitializeComponent();
        }

        private void FormEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                grillaJugadores.Cargar(controladora.TraerJugadoresSinEquipo());
            }
            catch (PersistenciaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void FormEquipo_Shown(object sender, EventArgs e)
        {
            grillaJugadores.LimpiarSeleccion();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Equipo equipo;

            try
            {
                equipo = controladora.CrearEquipo(txtNombre.Text, grillaJugadores.Seleccionada);
            }
            catch (ValidacionException ex)
            {
                MessageBox.Show(ex.Message, "Revisá los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            catch (PersistenciaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"Equipo {equipo.Nombre} creado. Ya se le pueden sumar jugadores " +
                            "al agregarlos o desde Modificar jugador.");

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
