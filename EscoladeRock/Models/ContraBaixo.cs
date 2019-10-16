
using System;
using EscoladeRock.Interfaces;
namespace EscoladeRock.Models
{
    public class ContraBaixo: InstrumentoMusical, IPercussao, IHarmonia
    {
         public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo do ContraBaixo.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do ContraBaixo");
            return true;
        }
    }
}