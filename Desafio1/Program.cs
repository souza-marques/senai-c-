using System;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1 ;
            double altura;
            double perimetroRetangulo;
            double areaRetangulo;
            double pitagoras;
            double d;
            System.Console.WriteLine("Digite a base do  retangulo:");
            base1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura do retangulo:");
            altura = double.Parse(Console.ReadLine());
           
           System.Console.WriteLine("O perímetro do retangulo é: ");
           System.Console.WriteLine( perimetroRetangulo = ((2*base1) + (2*altura)));
           
            System.Console.WriteLine("A área do Retangulo é: ");
            System.Console.WriteLine(areaRetangulo = ((base1)*(altura)));

           
            pitagoras = ((base1 * base1) + (altura * altura ));
            d = (Math.Sqrt(pitagoras));
            System.Console.WriteLine($"A diagonal do retangulo é: {d}");    
        }
    }
}
