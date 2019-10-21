using System;
namespace ByteBank_Polimorfismo.Models
{
    public class ContaCorrente: ContaBancaria // classe derivada de ContaBancaria
    {
        public ContaCorrente( int Agencia, int NumeroConta, string Titular): base(Agencia,NumeroConta,Titular)
        
    {
     
    } 
    }
}