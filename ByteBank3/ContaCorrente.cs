namespace ByteBank3 {
    public class ContaCorrente {
        //Atributos da classe
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public ContaCorrente (int Agencia, int Numero, Cliente Titular) { // construtor
            this.Agencia = Agencia;
            this.Numero = Numero;
            this.Titular = Titular;
            this.Saldo = 0.0;
        }
        public double Deposito (double valor) { // método Depósito recebe um dado double e retorna double
            this.Saldo += valor; //soma o valor do depósito com o saldo da conta
            return this.Saldo; //retorna valor do saldo atualizado
        }
        public bool Saque (double saque) { // método Saque retorna um booleano e recebe um double
            if (saque <= this.Saldo) { // se o valor do saque for menor que o saldo, beleza
                this.Saldo -= saque;
                return true;
            } else {
                return false; // se a condição não for verdadeira,não será possível realizar o saque
            }
        }
        public bool Transferencia (ContaCorrente destino, double valorTransf) {
            if (this.Saque (valorTransf)) { // Verifica se a situação do "saque" está correta se sim, o valor da transferência podoe ser efetivado
                destino.Deposito (valorTransf); // envia o valor digitado anteriormente para conta 
                return true;
            } else {
                return false; // caso não, a tranferencia não poderá ser efetivada.
            }
        }
    }
}