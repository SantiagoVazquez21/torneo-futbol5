using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica;
using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.IGU
{
    // Un solo formulario para agregar y para modificar. Solo lee los campos y
    // muestra mensajes: las validaciones y la categoría las resuelve la Controladora.
    public partial class FormJugador : Form
    {
        private readonly Controladora controladora = new Controladora();

        private const string SinEquipo = "(Sin equipo)";

        // null = modo agregar; con valor = modo modificar esa inscripción.
        private readonly Inscripcion? inscripcionAModificar;

        // Último equipo elegido por el usuario: se mantiene aunque el combo se
        // recargue al cambiar la edad o el sexo. null = sin equipo.
        private int? equipoElegidoId;

        // Modo agregar: campos vacíos.
        public FormJugador()
        {
            InitializeComponent();
        }

        // Modo modificar: los campos se cargan con los datos de la inscripción.
        public FormJugador(Inscripcion inscripcion) : this()
        {
            inscripcionAModificar = inscripcion;
            equipoElegidoId = inscripcion.Equipo?.Id;

            Text = "Modificar jugador";
            lblTitulo.Text = "Modificar jugador";
            CargarCampos(inscripcion);
        }

        private void FormJugador_Load(object sender, EventArgs e)
        {
            try
            {
                controladora.TraerCategorias();
                controladora.TraerEquipos();
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
                CargarEquipos(null);
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

            CargarEquipos(categoria);
        }

        // Llena el combo con "(Sin equipo)" y los equipos que puede elegir según la categoría.
        private void CargarEquipos(Categoria? categoria)
        {
            List<object> opciones = new List<object> { SinEquipo };
            Equipo? equipoActual = inscripcionAModificar?.Equipo;

            // El capitán no puede dejar su equipo: se muestra solo el suyo, bloqueado.
            if (inscripcionAModificar != null && inscripcionAModificar.EsCapitan)
            {
                cmbEquipo.DataSource = new List<object> { equipoActual! };
                cmbEquipo.Enabled = false;
                lblEquipoNota.Text = "Es el capitán";
                return;
            }

            try
            {
                if (categoria != null)
                {
                    opciones.AddRange(controladora.EquiposDisponibles(categoria, inscripcionAModificar));
                }
            }
            catch (PersistenciaException)
            {
                return;
            }

            // Su equipo actual siempre aparece: si cambió de categoría, al guardar
            // la Controladora avisa en vez de sacarlo del equipo sin decir nada.
            if (equipoActual != null && !opciones.OfType<Equipo>().Any(e => e.Id == equipoActual.Id))
            {
                opciones.Add(equipoActual);
            }

            cmbEquipo.DataSource = opciones;
            cmbEquipo.SelectedItem = opciones.OfType<Equipo>().FirstOrDefault(e => e.Id == equipoElegidoId)
                                     ?? (object)SinEquipo;
        }

        // Solo se dispara cuando el usuario elige en el combo, no cuando se recarga por código.
        private void cmbEquipo_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            equipoElegidoId = (cmbEquipo.SelectedItem as Equipo)?.Id;
        }

        // "(Sin equipo)" es un texto, no un Equipo: en ese caso devuelve null.
        private Equipo? EquipoElegido()
        {
            return cmbEquipo.SelectedItem as Equipo;
        }

        // Filtros de teclado: e.Handled = true descarta el carácter. Las teclas de
        // control (Backspace, Ctrl+C, Ctrl+V) siempre pasan. Lo pegado no pasa por
        // acá, por eso la Controladora sigue validando al guardar.

        // Apellido y nombre. char.IsLetter acepta tildes y ñ.
        private void SoloLetras_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        // DNI y edad.
        private void SoloNumeros_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Números, espacios, guion y +, por ejemplo: +54 11 1234-5678.
        private void Telefono_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ' ' &&
                e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true;
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
                        txtEdad.Text, txtTelefono.Text, SexoElegido(), chkAbono.Checked, EquipoElegido());

                    MessageBox.Show($"Jugador agregado en la categoría {nueva.Categoria.Nombre}.");
                }
                else
                {
                    controladora.ModificarJugador(inscripcionAModificar,
                        txtApellido.Text, txtNombre.Text, txtDni.Text, txtDireccion.Text,
                        txtEdad.Text, txtTelefono.Text, SexoElegido(), chkAbono.Checked, EquipoElegido());

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
