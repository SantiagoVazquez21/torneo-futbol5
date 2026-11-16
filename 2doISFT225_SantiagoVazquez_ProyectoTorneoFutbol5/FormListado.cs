using MySql.Data.MySqlClient;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5
{
    public partial class FormListado : Form
    {
        private readonly InscripcionRepositorio inscripcionRepositorio = new InscripcionRepositorio();

        public FormListado()
        {
            InitializeComponent();

            CargarInscripciones();
        }

        // Se vuelve a leer todo de la base después de cada cambio: así la grilla
        // muestra siempre lo que realmente quedó guardado.
        private void CargarInscripciones()
        {
            dgvInscripciones.Rows.Clear();

            List<Inscripcion> inscripciones;

            try
            {
                inscripciones = inscripcionRepositorio.ObtenerTodas();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"No se pudo conectar a la base de datos.\n\n{ex.Message}\n\n" +
                    "Verificá la conexión a internet y el archivo conexion.local.txt.");
                return;
            }

            foreach (Inscripcion inscripcion in inscripciones)
            {
                Participante p = inscripcion.Participante;

                int fila = dgvInscripciones.Rows.Add(
                    inscripcion.Numero,
                    inscripcion.Fecha.ToString("dd/MM/yyyy"),
                    p.Apellido,
                    p.Nombre,
                    p.Dni ?? "",
                    p.Edad,
                    p.Sexo.ToString(),
                    p.Direccion,
                    p.Telefono ?? "",
                    inscripcion.Categoria.Nombre,
                    inscripcion.Abono);

                // Tag guarda el objeto completo para recuperarlo al elegir la fila.
                dgvInscripciones.Rows[fila].Tag = inscripcion;
            }

            dgvInscripciones.ClearSelection();
        }

        private Inscripcion? InscripcionSeleccionada()
        {
            if (dgvInscripciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una inscripción de la tabla.");
                return null;
            }

            return dgvInscripciones.SelectedRows[0].Tag as Inscripcion;
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

            DialogResult respuesta = MessageBox.Show(
                $"¿Está seguro de eliminar a {seleccionada.Participante}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
            {
                return;
            }

            try
            {
                inscripcionRepositorio.Eliminar(seleccionada);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudo eliminar en la base de datos.\n\n{ex.Message}");
                return;
            }

            CargarInscripciones();

            MessageBox.Show("Jugador eliminado correctamente.");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvInscripciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnModificar_Click(sender, e);
            }
        }

        // Al mostrarse, la grilla marca sola la primera fila; se limpia para que
        // no parezca seleccionada una inscripción que el usuario no eligió.
        private void FormListado_Shown(object sender, EventArgs e)
        {
            dgvInscripciones.ClearSelection();
        }
    }
}
