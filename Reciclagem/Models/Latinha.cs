using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Latinha : IMetal
    {
        public bool LixoAmarelo()
        {
          Console.BackgroundColor = ConsoleColor.Yellow;
          Console.ForegroundColor = ConsoleColor.Black;
          System.Console.WriteLine("Esse lixo corresponde a lixeria AMARELA pois é um metal");
          return true;
        }
        
    }
}