using System;

namespace SENAIzinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolher = 0;
            
            Console.WriteLine("1 - Cadastrar Aluno ");
            Console.WriteLine("2 - Cadastrar Sala ");
            System.Console.WriteLine(" 3 - Alocar Aluno");
            System.Console.WriteLine("4 - Remover Aluno");
            escolher = int.Parse(Console.ReadLine());
            Console.Clear();

            Aluno aluno = new Aluno();      
            switch(escolher)
            {
            case 1:
            System.Console.WriteLine("Digite o Nome do Aluno: ");
            string Nome = Console.ReadLine();
            System.Console.WriteLine("Digite a data de nascimento do aluno:");
            DateTime DataNascimento = DateTime.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o curso do aluno: ");
            string Curso = Console.ReadLine();
            System.Console.WriteLine("Digite o numero da sala:");
            int Numerosala = Console.ReadLine();
            break;
            
            
            
            
            
            
            }


        }
    }
}
