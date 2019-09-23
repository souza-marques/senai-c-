using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
           string login;
           string senha;

            Console.WriteLine("Digite seu login");
            login = Console.ReadLine();

            Console.WriteLine("Digite sua senha");
            senha = Console.ReadLine();

            if(login =="admin" && senha =="admin") {
            Console.WriteLine("Você é um administrador");
            } else if (login!="admin" && senha!="admin")
            { 
                Console.WriteLine("Você é um usuário");
            }
        }
    }
}
