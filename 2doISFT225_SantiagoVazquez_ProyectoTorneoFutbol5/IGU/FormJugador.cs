using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;
using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    // Un solo formulario para agregar y para modificar. Solo lee los campos y
    // muestra mensajes: las validaciones y la categoría las resuelve la Controladora.
    public partial class FormJugador : Form
    {
        private readonly Controladora controladora = new Controladora();

        // null = modo agregar; con valor = modo modificar esa inscripción.
        private readonly Inscripcion? inscripcionAModificar;

        // Modo agregar: campos vacíos.
        public FormJugador()
        {
            InitializeComponent();
        }

        // Modo modificar: los campos se cargan con los datos de la inscripción.
        public FormJugador(Inscripcion inscripcion) : this()
        {
            inscripcionAModificar = inscripcion;

            Text = "Modificar jugador";
            lblTitulo.Text = "Modificar jugador";
            CargarCampos(inscripcion);
        }

        private void FormJugador_Load(object sender, EventArgs e)
        {
            try
            {
                controladora.TraerCategorias();
            }
            catch (PersistenciaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // En modo modificar los campos ya están cargados; ahora que hay
            // categorías se puede mostrar cuál le corresponde.
            ActualizarCategoriaAsignada(this, EventArgs.Empty);
        }

        private void CargarCampos(Inscripcion inscripcion)
        {
            Participante p = inscripcion.Participante;

            txtApellido.Text = p.Apellido;
            txtNombre.Text = p.Nombre;
            txtDni.Text = p.Dni;
            txtDireccion.Text = p.Direccion;
            txtEdad.Text = p.Edad.ToString();
            txtTelefono.Text = p.Telefono;
            rdbMasculino.Checked = p.Sexo == 'M';
            rdbFemenino.Checked = p.Sexo == 'F';
            chkAbono.Checked = inscripcion.Abono;
        }

        private char? SexoElegido()
        {
            if (rdbMasculino.Checked)
            {
                return 'M';
            }

            if (rdbFemenino.Checked)
            {
                return 'F';
            }

            return null;
        }

        // Muestra en vivo qué categoría le va a tocar según edad y sexo.
        private void ActualizarCategoriaAsignada(object? sender, EventArgs e)
        {
            char? sexo = SexoElegido();

            if (!int.TryParse(txtEdad.Text, out int edad) || sexo == null)
            {
                lblCategoria.Text = "—";
                lblCategoria.ForeColor = SystemColors.ControlText;
                return;
            }

            Categoria? categoria;

            try
            {
                categoria = controladora.BuscarCategoria(edad, sexo.Value);
            }
            catch (PersistenciaException)
            {
                // Puede pasar antes del Load (al precargar los campos); el Load ya avisa si falla.
                return;
            }

            if (categoria == null)
            {
                lblCategoria.Text = "Sin categoría para esa edad";
                lblCategoria.ForeColor = Color.Firebrick;
            }
            else
            {
                lblCategoria.Text = categoria.Nombre;
                lblCategoria.ForeColor = Color.DarkGreen;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (inscripcionAModificar == null)
                {
                    Inscripcion nueva = controladora.AgregarJugador(
                        txtApellido.Text, txtNombre.Text, txtDni.Text, txtDireccion.Text,
                        txtEdad.Text, txtTelefono.Text, SexoElegido(), chkAbono.Checked);

                    MessageBox.Show($"Jugador agregado en la categoría {nueva.Categoria.Nombre}.");
                }
                else
                {
                    controladora.ModificarJugador(inscripcionAModificar,
                        txtApellido.Text, txtNombre.Text, txtDni.Text, txtDireccion.Text,
                        txtEdad.Text, txtTelefono.Text, SexoElegido(), chkAbono.Checked);

                    MessageBox.Show("Jugador modificado correctamente.");
                }
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

            // OK le avisa a quien abrió el formulario que hubo cambios; en un
            // formulario abierto con ShowDialog, asignarlo también lo cierra.
            DialogResult = DialogResult.OK;
        }
    }
}
