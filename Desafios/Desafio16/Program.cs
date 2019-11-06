using System;

namespace Desafio16
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double altura;
            double peso;
            double imc;
            System.Console.WriteLine("CONTROLE DE PACIENTES ");

            System.Console.WriteLine("Olá,Identifique-se por favor :");
            nome = Console.ReadLine();
            
            System.Console.WriteLine("Digite sua altura(metros):");
            altura = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite seu peso(Kg):");
            peso = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("");
            Paciente paciente1 = new Paciente(nome,altura,peso);
            System.Console.WriteLine($"Olá {nome}");
            
           imc = peso /(altura * altura);
           imc = int.Parse(Console.ReadLine());
           

           if (imc < 20){
               System.Console.WriteLine($"O seu imc é {imc} e você está abaixo do peso.");
           } else if (( imc => 20) && (imc <= 25)){
               System.Console.WriteLine($"Seu imc é {imc} e você está com peso normal.");
           } else if((imc => 25) && (imc <= 30)){
               System.Console.WriteLine($"Seu imc é {imc} e você está come excesso de peso.  ");
           } else if ((imc > 30) && (imc <= 35)){
               System.Console.WriteLine($"Seu imc é {imc} e você está obeso.");
           } else if ((imc > 35)){
               System.Console.WriteLine($"Seu imc é {imc} e você está com obesidade mórbida.");
           }

           }
         

            



        }
    }
}
