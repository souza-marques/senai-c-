using System;

namespace Reciclagem
{
    class Program
    {
        static void Main(string[] args)
        {


        

            string menuBar = "===============================================";
           System.Console.WriteLine(menuBar);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("============================================");
                    
                    System.Console.WriteLine("     Seja bem vindo a Lixeira virtual       ");

                    System.Console.WriteLine("============================================");

                    Console.ResetColor();
                    System.Console.WriteLine(menuBar);
                  
                System.Console.WriteLine("Digite qual opção que você deseja descartar:   ");
                System.Console.WriteLine("1.Garrafa");
                System.Console.WriteLine("2.GarrafaPET");
                System.Console.WriteLine("3.GuardaChuva");
                System.Console.WriteLine("4.Latinha");
                System.Console.WriteLine("5.Papelao");
                System.Console.WriteLine("PoteManteiga");
        
        }
    }
}
