using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double centigrados;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Digite a temperatura em centígrados(C°): ");
            Console.ResetColor();
            centigrados = double.Parse(Console.ReadLine());
            System.Console.WriteLine($"A temperatura é :{(9*centigrados + 160)/5}F ");
        }
    }
}
