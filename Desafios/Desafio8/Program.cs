using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        {   int
         h;
            System.Console.WriteLine("Qual a altura do triangulo: ");
            h = int.Parse(Console.ReadLine());

            for(string i ="*";i = h; i++){
                System.Console.WriteLine($"{i}");
            }
        }
    }
}
