using System;
using Reciclagem.Interfaces;
namespace Reciclagem.Models
{
    public class Papelao : IPapel
    {
        public bool LixoAzul()
        {
          Console.BackgroundColor = ConsoleColor.Blue;
          Console.ForegroundColor = ConsoleColor.Black;
          System.Console.WriteLine("Esse lixo corresponde a lixeria  de cor Azul pois é um papelão");
         return true;
        }
        }
    }
