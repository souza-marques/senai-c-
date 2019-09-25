using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        { 
        int n = 0;
     
        int [] vetor = new int[6];
       int x = vetor[0];
       int y = vetor [1];
       int z = vetor  [2];
        Console.WriteLine("digite os seis primeiros números");
        n = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());

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
