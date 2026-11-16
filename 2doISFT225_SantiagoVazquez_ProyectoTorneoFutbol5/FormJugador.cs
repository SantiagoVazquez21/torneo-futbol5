using MySql.Data.MySqlClient;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5
{
    // Un solo formulario para agregar y para modificar: la validación y la
    // asignación de categoría quedan escritas una vez y sirven para los dos casos.
    public partial class FormJugador : Form
    {
        private readonly InscripcionRepositorio inscripcionRepositorio = new InscripcionRepositorio();
        private readonly CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();

        private List<Categoria> categorias = new List<Categoria>();

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
            CargarCampos(inscripcion);
        }

        private void FormJugador_Load(object sender, EventArgs e)
        {
            try
            {
                categorias = categoriaRepositorio.ObtenerTodas();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    $"No se pudieron cargar las categorías.\n\n{ex.Message}\n\n" +
                    "Verificá la conexión a internet y el archivo conexion.local.txt.");
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

        private Categoria? BuscarCategoria(int edad, char sexo)
        {
            return categorias.Find(c => c.Admite(edad, sexo));
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

            Categoria? categoria = BuscarCategoria(edad, sexo.Value);

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

        // Valida la planilla y arma el participante con su categoría.
        // Devuelve false (y ya avisó al usuario) si algo no está bien.
        private bool TryLeerPlanilla(out Participante participante, out Categoria categoria)
        {
            participante = new Participante();
            categoria = new Categoria();

            string apellido = txtApellido.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string dni = txtDni.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (apellido == "" || nombre == "" || direccion == "" || txtEdad.Text.Trim() == "")
            {
                MessageBox.Show("Complete apellido, nombre, dirección y edad.");
                return false;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("La edad debe ser un número entero mayor a 0.");
                return false;
            }

            char? sexo = SexoElegido();

            if (sexo == null)
            {
                MessageBox.Show("Seleccione el sexo.");
                return false;
            }

            if (dni != "" && !dni.All(char.IsDigit))
            {
                MessageBox.Show("El DNI debe contener solo números.");
                return false;
            }

            Categoria? encontrada = BuscarCategoria(edad, sexo.Value);

            if (encontrada == null)
            {
                string sexoTexto = sexo == 'M' ? "masculino" : "femenino";
                MessageBox.Show(
                    $"No hay una categoría {sexoTexto} para {edad} años.\n\n" +
                    $"Las categorías del torneo van de {categorias.Min(c => c.EdadMin)} " +
                    $"a {categorias.Max(c => c.EdadMax)} años.");
                return false;
            }

            participante = new Participante
            {
                Apellido = apellido,
                Nombre = nombre,
                Dni = dni == "" ? null : dni,
                Direccion = direccion,
                Edad = edad,
                Telefono = telefono == "" ? null : telefono,
                Sexo = sexo.Value,
            };
            categoria = encontrada;

            return true;
        }

        private bool DniRepetido(Participante participante)
        {
            if (participante.Dni == null)
            {
                return false;
            }

            if (inscripcionRepositorio.ExisteDni(participante.Dni, participante.Id))
            {
                MessageBox.Show($"Ya hay una persona inscripta con el DNI {participante.Dni}.");
                return true;
            }

            return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!TryLeerPlanilla(out Participante participante, out Categoria categoria))
            {
                return;
            }

            Inscripcion inscripcion = new Inscripcion(participante, categoria)
            {
                Abono = chkAbono.Checked,
            };

            // Al modificar se conservan los identificadores y la fecha original.
            if (inscripcionAModificar != null)
            {
                participante.Id = inscripcionAModificar.Participante.Id;
                inscripcion.Numero = inscripcionAModificar.Numero;
                inscripcion.Fecha = inscripcionAModificar.Fecha;
            }

            try
            {
                if (DniRepetido(participante))
                {
                    return;
                }

                if (inscripcionAModificar == null)
                {
                    inscripcionRepositorio.Insertar(inscripcion);
                }
                else
                {
                    inscripcionRepositorio.Actualizar(inscripcion);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"No se pudo guardar en la base de datos.\n\n{ex.Message}");
                return;
            }

            MessageBox.Show(inscripcionAModificar == null
                ? $"Jugador agregado en la categoría {categoria.Nombre}."
                : "Jugador modificado correctamente.");

            // OK le avisa a quien abrió el formulario que hubo cambios; en un
            // formulario abierto con ShowDialog, asignarlo también lo cierra.
            DialogResult = DialogResult.OK;
        }
    }
}
