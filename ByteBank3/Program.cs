﻿using System;
namespace ByteBank3 {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Cadastro de Clientes");
            System.Console.WriteLine ();
            System.Console.Write ("Nome: ");
            string nome = Console.ReadLine ();
            System.Console.Write ("CPF: ");
            string cpf = Console.ReadLine ();
            System.Console.Write ("Email: ");
            string email = Console.ReadLine ();
            Cliente cliente1 = new Cliente (nome, cpf, email);
            bool senhaOk = false;
            do {
                System.Console.Write ("Digite a Senha: ");
                string senha = Console.ReadLine ();
                senhaOk = cliente1.TrocaSenha (senha);
                if (!senhaOk) {
                    System.Console.WriteLine ("Senha não atende aos requisitos !");
                } else {
                    System.Console.WriteLine ("Senha trocada com sucesso !");
                }
            } while (!senhaOk);
            System.Console.WriteLine ("Cadastro de Conta Corrente");
            System.Console.WriteLine ();
            //System.Console.Write ("Nome do Titular: ");
            //string titular = Console.ReadLine ();
            System.Console.Write ("Agência: ");
            int agencia = int.Parse (Console.ReadLine ());
            System.Console.Write ("Número da conta: ");
            int numero = int.Parse (Console.ReadLine ());
            bool saldoValido = false;
            double saldo;
            do {
                System.Console.Write ("Digite o Saldo: ");
                 saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    System.Console.WriteLine ("O saldo não pode ser negativo!");
                }
            } while (!saldoValido);
            ContaCorrente contaCorrente = new ContaCorrente (agencia, numero, cliente1);
            contaCorrente.Saldo = saldo;

            System.Console.WriteLine ("ByteBank- Deposito");
            Cliente usuario = contaCorrente.Titular;
            Console.WriteLine ($"Bem vindo - {usuario.Nome}");
            System.Console.WriteLine($"Agencia: {contaCorrente.Agencia}   Conta:{contaCorrente.Numero}");
            System.Console.WriteLine($"Saldo:{contaCorrente.Saldo}");
            System.Console.Write ("Digite o valor do Deposito");
            double valor = double.Parse (Console.ReadLine ());
            saldo = contaCorrente.Deposito(valor);
            contaCorrente.Deposito (valor);
            System.Console.WriteLine ();
            System.Console.WriteLine ("ByteBank- Saque");
            System.Console.WriteLine ("Qual o valor do Saque ?");
            valor = double.Parse(Console.ReadLine ());
            if (contaCorrente.Saque (valor)) {
                System.Console.WriteLine ("Saque realizado com sucesso. Retire as notas");
            } else {
                System.Console.WriteLine ("Não foi possível realizar a operação");
            }
            Console.WriteLine ();

            Console.WriteLine ("ByteBank-Transferencia");
            System.Console.Write ("Digite o valor da tranferencia:");
            valor = double.Parse (Console.ReadLine ());
            Cliente cliente2 = new Cliente ("Alexandre", "123.321.123-12","a@a.com");
            ContaCorrente contaCorrente2 = new ContaCorrente (123,132,cliente2);
            if (contaCorrente.Transferencia(contaCorrente,valor)){
                System.Console.WriteLine("Transferencia efetuada com sucesso.");
            }else{
                System.Console.WriteLine("Operação não pode ser realizada.");
            }
            System.Console.WriteLine($"Saldo origem:{contaCorrente.Saldo}");
            System.Console.WriteLine($"Saldo destino:{contaCorrente2.Saldo}");

        }
    }
}