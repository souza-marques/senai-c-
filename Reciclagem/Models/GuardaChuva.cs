using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class GuardaChuva 
    {
        public bool LixoCinza()
        {
          Console.BackgroundColor = ConsoleColor.Gray;
          Console.ForegroundColor = ConsoleColor.Black;
          System.Console.WriteLine("Esse lixo corresponde a lixeria CINZA pois é um lixo não reciclavel");
          return true;
        }
    }
}