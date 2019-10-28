using System;

namespace Desafio8
{
    class Program
    {
        static void Main(string[] args)
        { System.Console.WriteLine("======Desenho Triangulo======");
          System.Console.WriteLine("Qual a altura do triangulo: ");
           int h = int.Parse(Console.ReadLine());

            for(int i=0;i<=h;i++){
                for(int j=i;j<h;j++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine("");
               
            }
            string estrelas = "";
            for(int x = 0; x < h; x++){
                estrelas +="*";
                System.Console.WriteLine(estrelas);
            }
        }
    }
}
