namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica
{
    public class Inscripcion
    {
        // 0 = todavía no guardada en la base.
        public int Numero { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Today;

        public bool Abono { get; set; }

        public Participante Participante { get; set; }

        public Categoria Categoria { get; set; }

        // null = todavía sin equipo (se puede asignar después).
        public Equipo? Equipo { get; set; }

        public bool EsCapitan => Equipo != null && Equipo.IdCapitan == Participante.Id;

        public Inscripcion(Participante participante, Categoria categoria)
        {
            Participante = participante;
            Categoria = categoria;
        }
    }
}
