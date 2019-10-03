using System;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("Cadastro de Conta Corrente");
        System.Console.WriteLine();
        System.Console.Write("Agência:");
        int agencia  = int.Parse(Console.ReadLine()); 
        Console.Write("Conta:");
        int Conta = int.Parse(Console.ReadLine());
        System.Console.Write("Titular:");
        string titular = Console.ReadLine();
       
        bool SaldoValido = false;

         do{
             System.Console.WriteLine("Digite o Saldo: ");
            double saldo = double.Parse(Console.ReadLine());
              if(saldo >=0 ){
                 SaldoValido = true;
              } else{
                  System.Console.WriteLine("O saldo não pode ser negativo");
              }
         }while (!SaldoValido);
       
        }
    }
}
