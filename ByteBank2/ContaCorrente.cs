namespace ByteBank2
{
    public class ContaCorrente
    {
        string Titular {get;set;}
        int Agencia {get;set;}
        int Numero {get;set;}
        double Saldo {get;set;}
        
          public ContaCorrente(int Agencia,int Numero,string Titular){
              this.Agencia = Agencia;
              this.Numero = Numero;
              this.Titular = Titular;
              this.Saldo = 0.0;
          }

    
    }
}