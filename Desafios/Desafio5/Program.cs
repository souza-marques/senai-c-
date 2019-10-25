using System;

namespace Desafio5
{
    class Program
    {
        static void Main(string[] args)
        {
           float a;
           float b;
           float aux = 0;
            

        
            System.Console.WriteLine("Digite o valor da variável a:");
            a = float.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da variável b:");
            b = float.Parse(Console.ReadLine());
            


           System.Console.WriteLine($"O valor da variável b é {aux}, e o da variável a é {b}");
            a = aux;
            aux = b;
            b = a; 
        }
    }
}
