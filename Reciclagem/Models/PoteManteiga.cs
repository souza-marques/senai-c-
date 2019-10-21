using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class PoteManteiga : IPlastico
    {
         public bool LixoVermelho()
        {
          Console.BackgroundColor = ConsoleColor.Red;
          Console.ForegroundColor = ConsoleColor.Black;
          System.Console.WriteLine("Esse lixo corresponde a lixeria VERMELHA pois é um plástico");
         return true;
        }
    }
}