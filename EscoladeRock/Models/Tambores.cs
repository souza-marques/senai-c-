using System;
using EscoladeRock.Interfaces;

namespace EscoladeRock.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
       public bool ManterRitmo()
       {
           System.Console.WriteLine("Mantendo o ritmo dos Tambores");
           return true;
       }
    }
}