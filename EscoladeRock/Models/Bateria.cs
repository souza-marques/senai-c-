using System;
namespace EscoladeRock.Models
{
    public class Bateria : InstrumentoMusical, IPercussao , IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da Bateria.");
            return true;
        }
    }
}