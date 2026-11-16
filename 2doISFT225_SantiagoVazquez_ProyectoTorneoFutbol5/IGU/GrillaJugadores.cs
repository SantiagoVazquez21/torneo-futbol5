using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    // Tabla de jugadores reutilizable: la usan el listado y la pantalla de crear
    // equipo, así las columnas y la forma de cargarla están escritas una sola vez.
    public partial class GrillaJugadores : UserControl
    {
        // Se dispara al hacer doble clic sobre una fila.
        public event EventHandler? JugadorDobleClic;

        public GrillaJugadores()
        {
            InitializeComponent();
        }

        public void Cargar(List<Inscripcion> inscripciones)
        {
            dgvJugadores.Rows.Clear();

            foreach (Inscripcion inscripcion in inscripciones)
            {
                Participante p = inscripcion.Participante;

                string equipo = inscripcion.Equipo == null
                    ? "—"
                    : inscripcion.EsCapitan ? $"{inscripcion.Equipo.Nombre} (C)" : inscripcion.Equipo.Nombre;

                int fila = dgvJugadores.Rows.Add(
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
                    equipo,
                    inscripcion.Abono);

                // Tag guarda el objeto completo para recuperarlo al elegir la fila.
                dgvJugadores.Rows[fila].Tag = inscripcion;
            }

            LimpiarSeleccion();
        }

        // null si no hay ninguna fila elegida.
        public Inscripcion? Seleccionada =>
            dgvJugadores.SelectedRows.Count == 0 ? null : dgvJugadores.SelectedRows[0].Tag as Inscripcion;

        // La grilla marca sola la primera fila al mostrarse; los formularios llaman
        // a esto en su Shown para que no parezca elegido un jugador que nadie eligió.
        public void LimpiarSeleccion()
        {
            dgvJugadores.ClearSelection();
        }

        private void dgvJugadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                JugadorDobleClic?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
