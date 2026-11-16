namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica
{
    public class Equipo
    {
        public const int MaximoJugadores = 5;

        // 0 = todavía no guardado en la base.
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        // Categoría en la que juega: la del capitán.
        public int IdCategoria { get; set; }

        // Id del participante capitán.
        public int IdCapitan { get; set; }

        // Jugadores anotados, contando al capitán.
        public int CantidadJugadores { get; set; }

        public bool TieneLugar => CantidadJugadores < MaximoJugadores;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
