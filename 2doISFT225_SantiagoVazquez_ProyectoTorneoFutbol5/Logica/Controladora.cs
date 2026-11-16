using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica
{
    // Puerta de entrada de la IGU: los formularios solo hablan con esta clase.
    // Acá están las reglas del torneo; guardar y leer lo hace Persistencia.
    public class Controladora
    {
        private readonly ControladoraPersistencia persistencia = new ControladoraPersistencia();

        private List<Categoria>? categorias;

        public List<Categoria> TraerCategorias()
        {
            // Se leen una sola vez: no cambian mientras la app está abierta.
            categorias ??= persistencia.TraerCategorias();
            return categorias;
        }

        public List<Inscripcion> TraerInscripciones()
        {
            return persistencia.TraerInscripciones();
        }

        public Categoria? BuscarCategoria(int edad, char sexo)
        {
            return TraerCategorias().Find(c => c.Admite(edad, sexo));
        }

        public Inscripcion AgregarJugador(string apellido, string nombre, string dni, string direccion,
                                          string edadTexto, string telefono, char? sexo, bool abono)
        {
            Participante participante = ArmarParticipante(apellido, nombre, dni, direccion, edadTexto, telefono, sexo);
            Categoria categoria = AsignarCategoria(participante);
            ValidarDniUnico(participante);

            Inscripcion inscripcion = new Inscripcion(participante, categoria)
            {
                Abono = abono,
            };

            persistencia.CrearInscripcion(inscripcion);
            return inscripcion;
        }

        public Inscripcion ModificarJugador(Inscripcion original, string apellido, string nombre, string dni,
                                            string direccion, string edadTexto, string telefono, char? sexo, bool abono)
        {
            Participante participante = ArmarParticipante(apellido, nombre, dni, direccion, edadTexto, telefono, sexo);

            // Mismo participante y misma inscripción: se conservan los ids y la fecha original.
            participante.Id = original.Participante.Id;

            Categoria categoria = AsignarCategoria(participante);
            ValidarDniUnico(participante);

            Inscripcion modificada = new Inscripcion(participante, categoria)
            {
                Numero = original.Numero,
                Fecha = original.Fecha,
                Abono = abono,
            };

            persistencia.EditarInscripcion(modificada);
            return modificada;
        }

        public void EliminarJugador(Inscripcion inscripcion)
        {
            persistencia.EliminarInscripcion(inscripcion);
        }

        // Valida los datos de la planilla y arma el participante.
        private static Participante ArmarParticipante(string apellido, string nombre, string dni, string direccion,
                                                      string edadTexto, string telefono, char? sexo)
        {
            apellido = apellido.Trim();
            nombre = nombre.Trim();
            dni = dni.Trim();
            direccion = direccion.Trim();
            telefono = telefono.Trim();

            if (apellido == "" || nombre == "" || direccion == "" || edadTexto.Trim() == "")
            {
                throw new ValidacionException("Complete apellido, nombre, dirección y edad.");
            }

            if (!int.TryParse(edadTexto, out int edad) || edad <= 0)
            {
                throw new ValidacionException("La edad debe ser un número entero mayor a 0.");
            }

            if (sexo == null)
            {
                throw new ValidacionException("Seleccione el sexo.");
            }

            if (dni != "" && !dni.All(char.IsDigit))
            {
                throw new ValidacionException("El DNI debe contener solo números.");
            }

            return new Participante
            {
                Apellido = apellido,
                Nombre = nombre,
                Dni = dni == "" ? null : dni,
                Direccion = direccion,
                Edad = edad,
                Telefono = telefono == "" ? null : telefono,
                Sexo = sexo.Value,
            };
        }

        // La categoría no la elige el usuario: sale de la edad y el sexo.
        private Categoria AsignarCategoria(Participante participante)
        {
            Categoria? categoria = BuscarCategoria(participante.Edad, participante.Sexo);

            if (categoria == null)
            {
                string sexoTexto = participante.Sexo == 'M' ? "masculino" : "femenino";
                throw new ValidacionException(
                    $"No hay una categoría {sexoTexto} para {participante.Edad} años.\n\n" +
                    $"Las categorías del torneo van de {TraerCategorias().Min(c => c.EdadMin)} " +
                    $"a {TraerCategorias().Max(c => c.EdadMax)} años.");
            }

            return categoria;
        }

        private void ValidarDniUnico(Participante participante)
        {
            // Al modificar, el propio participante no cuenta como repetido (por eso se pasa su Id).
            if (participante.Dni != null && persistencia.ExisteDni(participante.Dni, participante.Id))
            {
                throw new ValidacionException($"Ya hay una persona inscripta con el DNI {participante.Dni}.");
            }
        }
    }
}
