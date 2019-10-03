using System;

namespace ByteBank {
    class Program {
        static void Main (string[] args) {

        
        
        Console.WriteLine("Cadastro de Cliente");
        Console.WriteLine();
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        System.Console.Write("Cpf ");
        string cpf = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
         
         cliente cliente1 = new cliente (nome,cpf,email);
         bool senhaOk = false;
         do{
             System.Console.WriteLine("Digite a Senha: ");
             string senha = Console.ReadLine();
              senhaOk = cliente1.TrocaSenha(senha);
              if(!senhaOk){
                  System.Console.WriteLine("Senha não atende aos requisitos");

              } else{
                  System.Console.WriteLine("Senha trocada com sucesso");
              }
         }while (!senhaOk);
        }
    }
}