using System;

namespace Classificação_idade
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Digite o ano em que nasceu");
              x = int.Parse(Console.ReadLine());

             string x = 0;
         
           switch(idade){
               case 1:
               Console.WriteLine(x <= 2);
               Console.WriteLine("Você é recém-nascido");
               break;
               case 2: 
               Console.WriteLine( x=3, x<=11, x++);
               Console.WriteLine("Você é  uma criança");
               break;
               case 3:
               Console.WriteLine( x=12, x <=19, x++);
               Console.WriteLine("Você é um adolescente");
               break;
               case 4:
               Console.WriteLine( x=20, x <=65, x++);
               Console.WriteLine("Você é Adulto");
               break;
               case 5:
               Console.WriteLine(x =>65);
               Console.WriteLine("Você é um idoso");
               break;

           }
        }
    }
}
