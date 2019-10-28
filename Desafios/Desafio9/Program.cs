using System;

namespace Desafio9
{
    class Program
    { //Pterra/10 * gravidade
        static void Main(string[] args)
        {  
            
            
             Console.WriteLine("||| CALCULO DE PESO|||");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            int Planeta;
            double pterra;
            System.Console.WriteLine("Digite seu peso(kg) na Terra:  ");
            pterra = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("|   | Gravidade Relativa | Planeta  |");
            System.Console.WriteLine("|---|--------------------|----------|");
            System.Console.WriteLine("| 1 | 0,37               | Mercúrio |");
            System.Console.WriteLine("| 2 | 0,88               | Vênus    |");
            System.Console.WriteLine("| 3 | 0,38               | Marte    |");
            System.Console.WriteLine("| 4 | 2,64               | Júpiter  |");
            System.Console.WriteLine("| 5 | 1,15               | Saturno  |");
            System.Console.WriteLine("| 6 | 1,17               | Urano    |");
            System.Console.WriteLine("Digite o planeta desejado: ");
            Planeta = int.Parse(Console.ReadLine());
            
            switch(Planeta){
                case 1 : System.Console.WriteLine($"O seu peso em Mercúrio é {pterra/10 * 0.37} Kg ");
                break;
                case 2 : System.Console.WriteLine($"O seu peso em Vênus é {pterra/10 * 0.88} kg");
                break;
                case 3 : System.Console.WriteLine($"O seu peso em Marte é {pterra/10 * 0.38}kg");
                break;
                case 4  : System.Console.WriteLine($"O seu peso em Júpiter é {pterra/10 * 2.64}kg");
                break;
                case 5: System.Console.WriteLine($"O seu peso em Saturno é {pterra/10 * 1.15}kg");
                break;
                case 6: System.Console.WriteLine($"O seu peso em Urano é {pterra/10 * 1.17}kg");
                break;
                
            }
       
        }
    }
}
