using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            int numero = 0;
            
            do {
            Console.WriteLine("Digite um numero inteiro");
            numero = int.Parse(Console.ReadLine());

            if (numero == 0){
                Console.WriteLine(" Fim do programa");
            } else
            
             if (numero % 2 == 0) {
            Console.WriteLine("Seu número é par");
              }
            else {
            Console.WriteLine(" Seu número é ímpar");
            }
            
            } while (numero !=0);
        }
    }
}
