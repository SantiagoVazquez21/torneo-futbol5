using _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Persistencia;

namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica
{
    // Puerta de entrada de la IGU: los formularios solo hablan con esta clase.
    // Acá están las reglas del torneo; guardar y leer lo hace Persistencia.
    public class Controladora
    {
        private readonly ControladoraPersistencia persistencia = new ControladoraPersistencia();

        private List<Categoria>? categorias;
        private List<Equipo>? equipos;

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

        // ----- Equipos -----

        public List<Equipo> TraerEquipos()
        {
            // Se guardan mientras dura el formulario, para no ir a la base en cada
            // cambio del combo. El cupo se vuelve a controlar contra la base al guardar.
            equipos ??= persistencia.TraerEquipos();
            return equipos;
        }

        // Equipos que se pueden elegir para un jugador de esa categoría: los que
        // tienen lugar, más el equipo en el que ya está (aunque esté lleno).
        public List<Equipo> EquiposDisponibles(Categoria categoria, Inscripcion? actual)
        {
            return TraerEquipos()
                .Where(e => e.IdCategoria == categoria.Id && (e.TieneLugar || e.Id == actual?.Equipo?.Id))
                .ToList();
        }

        // Para elegir capitán: solo los jugadores que todavía no tienen equipo.
        public List<Inscripcion> TraerJugadoresSinEquipo()
        {
            return TraerInscripciones().Where(i => i.Equipo == null).ToList();
        }

        public Equipo CrearEquipo(string nombre, Inscripcion? capitan)
        {
            nombre = nombre.Trim();

            if (nombre == "")
            {
                throw new ValidacionException("Escriba el nombre del equipo.");
            }

            if (capitan == null)
            {
                throw new ValidacionException("Seleccione al capitán en la tabla.");
            }

            if (capitan.Equipo != null)
            {
                throw new ValidacionException($"{capitan.Participante} ya está en el equipo {capitan.Equipo.Nombre}.");
            }

            if (persistencia.ExisteNombreEquipo(nombre))
            {
                throw new ValidacionException($"Ya existe un equipo llamado {nombre}.");
            }

            // El equipo juega en la categoría del capitán, y el capitán es su primer jugador.
            Equipo equipo = new Equipo
            {
                Nombre = nombre,
                IdCategoria = capitan.Categoria.Id,
                IdCapitan = capitan.Participante.Id,
            };

            persistencia.CrearEquipo(equipo, capitan);
            equipos = null;

            return equipo;
        }

        // ----- Jugadores -----

        public Inscripcion AgregarJugador(string apellido, string nombre, string dni, string direccion,
                                          string edadTexto, string telefono, char? sexo, bool abono, Equipo? equipo)
        {
            Participante participante = ArmarParticipante(apellido, nombre, dni, direccion, edadTexto, telefono, sexo);
            Categoria categoria = AsignarCategoria(participante);
            ValidarDniUnico(participante);
            ValidarEquipo(equipo, categoria, null);

            Inscripcion inscripcion = new Inscripcion(participante, categoria)
            {
                Abono = abono,
                Equipo = equipo,
            };

            persistencia.CrearInscripcion(inscripcion);
            return inscripcion;
        }

        public Inscripcion ModificarJugador(Inscripcion original, string apellido, string nombre, string dni,
                                            string direccion, string edadTexto, string telefono, char? sexo,
                                            bool abono, Equipo? equipo)
        {
            Participante participante = ArmarParticipante(apellido, nombre, dni, direccion, edadTexto, telefono, sexo);

            // Mismo participante y misma inscripción: se conservan los ids y la fecha original.
            participante.Id = original.Participante.Id;

            Categoria categoria = AsignarCategoria(participante);
            ValidarDniUnico(participante);
            ValidarEquipo(equipo, categoria, original);

            Inscripcion modificada = new Inscripcion(participante, categoria)
            {
                Numero = original.Numero,
                Fecha = original.Fecha,
                Abono = abono,
                Equipo = equipo,
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

        // original = null al agregar; al modificar, la inscripción como estaba antes.
        private void ValidarEquipo(Equipo? equipo, Categoria categoria, Inscripcion? original)
        {
            Equipo? equipoAnterior = original?.Equipo;

            if (original != null && original.EsCapitan && equipo?.Id != equipoAnterior!.Id)
            {
                throw new ValidacionException(
                    $"{original.Participante} es capitán de {equipoAnterior.Nombre}: no puede dejar su equipo.");
            }

            if (equipo == null)
            {
                return;
            }

            // Si ya estaba en ese equipo, no ocupa un lugar nuevo.
            bool yaEstaba = equipoAnterior?.Id == equipo.Id;

            if (equipo.IdCategoria != categoria.Id)
            {
                string categoriaEquipo = TraerCategorias().Find(c => c.Id == equipo.IdCategoria)?.Nombre ?? "otra categoría";

                if (original != null && original.EsCapitan)
                {
                    throw new ValidacionException(
                        $"Es capitán de {equipo.Nombre}, que juega en {categoriaEquipo}: " +
                        $"con estos datos pasaría a {categoria.Nombre}.");
                }

                throw new ValidacionException(yaEstaba
                    ? $"El equipo {equipo.Nombre} juega en {categoriaEquipo} y con estos datos el jugador " +
                      $"queda en {categoria.Nombre}. Sacalo del equipo primero."
                    : $"El equipo {equipo.Nombre} juega en {categoriaEquipo} y el jugador está en {categoria.Nombre}.");
            }

            if (!yaEstaba && persistencia.ContarJugadoresEquipo(equipo.Id) >= Equipo.MaximoJugadores)
            {
                throw new ValidacionException(
                    $"El equipo {equipo.Nombre} ya tiene {Equipo.MaximoJugadores} jugadores.");
            }
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
