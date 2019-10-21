using System;
using ByteBank_Polimorfismo.Models;

namespace ByteBank_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           string cliente1 = "Alexandre";
           string cliente2 = "Cesar";
           
           ContaBancaria contaCorrente = new ContaBancaria(1,1,cliente1);
           ContaBancaria contaEspecial = new ContaBancaria(1,2,cliente2);
        }
    }
}
