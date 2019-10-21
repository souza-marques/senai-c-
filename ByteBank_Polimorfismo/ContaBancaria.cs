using System;
namespace ByteBank_Polimorfismo
{
    public abstract class ContaBancaria // esta classe não será utilizada somente suas classes filhas
    {
        public string Titular;
        public int Agencia;
        public int NumeroConta;
        public double Saldo;
        public ContaBancaria(int Agencia, int NumeroConta,string Titular)
        {
            this.Agencia = Agencia;
            this.NumeroConta = NumeroConta;
            this.Saldo = 0.0;
        }

        public abstract bool Saque(double valor);

        public bool Deposito(double valor)
        {
            if(valor >= 0)
            {
                this.Saldo += valor;
                 return true;
            }
        }
        public bool Transferencia(ContaBancaria destino, double valor)
        {
            if (this.Saque(valor))
            {
                destino.Deposito(valor);
            return true;
            }
        }
    }
}