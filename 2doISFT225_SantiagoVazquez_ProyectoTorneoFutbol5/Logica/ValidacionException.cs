namespace _2doISFT225_SantiagoVazquez_ProyectoTorneoFutbol5.Logica
{
    // Un dato no cumple una regla del torneo (campo vacío, edad inválida, DNI
    // repetido...). No es una falla del programa: la IGU la muestra como aviso.
    public class ValidacionException : Exception
    {
        public ValidacionException(string mensaje) : base(mensaje)
        {
        }
    }
}
