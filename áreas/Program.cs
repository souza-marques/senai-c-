using System;

namespace áreas
{
    class Program
    {
        static void Main(string[] args)
        {
      float l1; 
      float l2;
      float b;
      float a;
      double pi = 3.14f;
      float r;
      float bmaior;
      float bmenor;
      float diagmenor;
      float diagmaior;
      string formas;

         Console.WriteLine("Digite a forma geometrica");
            Console.WriteLine("1-quadrado");
            Console.WriteLine("2-triângulo");
            Console.WriteLine("3- círculo");
            Console.WriteLine("4- trapézio ");
            Console.WriteLine("5- retângulo");
            Console.WriteLine("6-losango");
            formas = Console.ReadLine(); 

             switch(formas) {
                  case  "quadrado":
                  Console.Write("Digite o valor l1");
                  l1 = float.Parse(Console.ReadLine());
                   Console.Write("Digite o valor l2");
                  l2 = float.Parse(Console.ReadLine());
                  Console.WriteLine("area = " + l1*l2);
                  break;
                  case "triângulo":
                  Console.Write("Digite o valor da base");
                   b = float.Parse(Console.ReadLine());
                   Console.Write("Digite o valor da altura");
                   a = float.Parse(Console.ReadLine());
                  Console.WriteLine("Area = " + b*a/2);
                  break;
                  case "círculo":
                  Console.Write("Digite o valor da pi");
                  pi = double.Parse(Console.ReadLine());
                  Console.Write("Digite o valor do raio");
                  r = float.Parse(Console.ReadLine());
                  Console.WriteLine("Area = " + pi * r*r);
                  break;
                  case "trapézio":
                   Console.Write("Digite o valor da altura");
                   a = float.Parse(Console.ReadLine());
                   Console.Write("Digite o valor da base maior");
                   bmaior = float.Parse(Console.ReadLine());
                   Console.Write("Digite o valor da base menor");
                   bmenor = float.Parse(Console.ReadLine());
                  Console.WriteLine("Area = " + bmaior*bmenor*a/2);
                  break;
                  case "retângulo":
                   Console.Write("Digite o valor da base");
                   b = float.Parse(Console.ReadLine());
                   Console.Write("Digite o valor da altura");
                   a = float.Parse(Console.ReadLine());
                   Console.WriteLine("Area = " + b*a);
                  break;
                    case "losango":
                 Console.Write("Digite o valor da diagonal maior");
                   diagmaior = float.Parse(Console.ReadLine());
                   Console.Write("Digite o valor da diagonal menor");
                   diagmenor = float.Parse(Console.ReadLine());
                   Console.WriteLine("Area = " + diagmaior*diagmenor);
                  break;
            }
        
       
            
          }
        }
    }

