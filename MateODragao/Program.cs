using System;
using MateODragao.Models;
namespace MateODragao {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("==============================");
                System.Console.WriteLine ("        Mate o Dragão!");
                System.Console.WriteLine ("==============================");

                System.Console.WriteLine (" 1 - Iniciar jogo");
                System.Console.WriteLine (" 0 - Sair do jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Aquiles";
                        guerreiro.Sobrenome = "Maximus";
                        guerreiro.CidadeNatal = "Roma";
                        guerreiro.DataNascimento = DateTime.Parse ("01/03/1350");
                        guerreiro.FerramentaAtaque = "Espada e ArcoFlecha";
                        guerreiro.Forca = 4;
                        guerreiro.Destreza = 3;
                        guerreiro.Inteligencia = 3;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragondoso";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;
                        /*INICIO- Primei2ro diálogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:{dragao.Nome},seu louco! Vim-lhe derrotar-te-lhe!");
                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:kkkkk! Humano tolinho.Quem pensas que é?");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        Console.Clear();
                        /*FIM- Primeiro diálogo */

                        /*INICIO - Segundo diálogo */
                        Console.Clear ();
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome},ó criatura morfética!");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} para derrotar-te e mostar meu valor!");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:QUEM? DE ONDE? Bom, que seja...fritar-te-ei, primata insolente!");
                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        /*FIM - Segundo diálogo */
                        Console.Clear ();
                        bool jogadorAtacaprimeiro =
                            guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /*INICIO - da treta */
                        if (jogadorAtacaprimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("Turno do jogador");
                            System.Console.WriteLine ("Escolha sua ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa lagarto MALDJEETO");
                                        dragao.Vida -=  poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("--------------");
                                        System.Console.WriteLine ($"HP Dragão:{dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro:{guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:Errrrrou, humanóide tosco! Vem tranquilo");
                                    }
                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Simbora fii!FLW VLW");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:GG EZ!");
                                    break;
                            }

                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine("*** Turno do Dragão***");
                                Random geradorNumeroAleatorio = new Random ();
                                int numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal  ) {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Chamuscou o fiofó? foi?");
                                   guerreiro.Vida -= dragao.Forca;
                                    System.Console.WriteLine ("--------------");
                                    System.Console.WriteLine ($"HP Dragão:{dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro:{guerreiro.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Vem tranquilo, não se afoba não!");
                                }
                                System.Console.WriteLine();
                                System.Console.WriteLine("Aperte ENTER para prosseguir");
                                Console.ReadLine();

                                                                                /*INICIO - turno jogador */
                            
                            Console.Clear();
                            System.Console.WriteLine ("Turno do jogador");
                            System.Console.WriteLine ("Escolha sua ação");
                            System.Console.WriteLine (" 1 - Atacar");
                            System.Console.WriteLine (" 2 - Fugir");

                             opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    geradorNumeroAleatorio = new Random ();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Toma essa lagarto MALDJEETO");
                                        dragao.Vida -=  poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("--------------");
                                        System.Console.WriteLine ($"HP Dragão:{dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro:{guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:Errrrrou, humanóide tosco! Vem tranquilo");
                                    }
                                    if (guerreiro.Vida <= 0)
                                    {
                                        System.Console.WriteLine("Jogador Murreeeeeu");
                                    }
                                    if (dragao.Vida <= 0) {
                                        System.Console.WriteLine("El dragón murió!");
                                    }
                                    System.Console.WriteLine();
                                    System.Console.WriteLine("Aperte ENTER para prosseguir");
                                    Console.ReadLine();

                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:Simbora fii!FLW VLW");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}:GG EZ!");
                                    break;
                            }
                            System.Console.WriteLine();
                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();
                                /*FIM - turno jogador */
                            }
                        }
                        /*FIM - da treta */

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;
                }
            } while (jogadorNaoDesistiu);

        }
    }
}