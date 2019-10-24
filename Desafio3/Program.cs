using System;

namespace Desafio2
{
    class Program
    {
        static void Main(string[] args)
        {   
            double velocidadeMedia;
            double tempo;
            double distancia;
           

            System.Console.WriteLine("Digite o tempo(em minutos) da viagem: ");
            tempo = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a velocidade media: ");
            velocidadeMedia = double.Parse(Console.ReadLine());

            distancia = velocidadeMedia * tempo/60;
            System.Console.WriteLine($"A distancia é de: {distancia} km");

            System.Console.WriteLine($"A quantidade de litros de gasolina usada foi de: {distancia/12} litros ");

        }
    }
}
