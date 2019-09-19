using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
         int idade = 0;
           Console.WriteLine("Qual a sua idade em anos?");
           idade = int.Parse(Console.ReadLine());
        
           Console.WriteLine("sua idade em dias é: " + idade * 365);

           Console.WriteLine("sua idade em meses é: " + idade * 12);

           Console.WriteLine("sua idade em horas é: " + idade * 8760);

           Console.WriteLine("sua idade em minutos é: " + idade * 525600);
    }
}
       
}

