using System;
namespace ByteBank_Polimorfismo.Models
{
    public class ContaEspecial: ContaBancaria
    {
        public double limite;
        public ContaEspecial(int Agencia, int NumeroConta, string Titular): base(Agencia, NumeroConta,Titular)
        {
             limite = 0.0;
        }
        public override bool Saque(double valor)
        {
            if (valor >= 0)
            {
                if (valor <= base.Saldo = limite)
                {
                    Saldo -= valor;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public void setLimite(double valor)
        {
            if(valor <= limite)
            {
                limite = valor;
                return true;
            }
            return false;
        }
    }
}