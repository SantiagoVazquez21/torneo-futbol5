namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    // Pantalla de inicio. Cada formulario se abre con ShowDialog: mientras está
    // abierto, el de atrás queda bloqueado y no se pueden abrir dos a la vez.
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarJugador_Click(object sender, EventArgs e)
        {
            using FormJugador formJugador = new FormJugador();
            formJugador.ShowDialog(this);
        }

        private void btnModificarJugador_Click(object sender, EventArgs e)
        {
            using FormListado formListado = new FormListado();
            formListado.ShowDialog(this);
        }

        // Al cerrar el formulario principal termina la aplicación.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
