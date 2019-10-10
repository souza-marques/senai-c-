using System;
using System.Collections.Generic;
using System.IO;

namespace TodoList {
    class Program {
        static int Main (string[] args) {
            List<TodoItem> todoList = new List<TodoItem> (); // <todoItem> representa o tipo de dado que vamos usar 
            string fileName = "todo.csv";
            string filePath = ".\\" + fileName;
            todoList = initList (@filePath);

            if (todoList == null) {
                return -1;
            }

            int opcao = 0;

            do {
                Console.Clear ();
                Console.WriteLine ("Todo List");
                Console.WriteLine ();
                ListaItens (todoList);
                Console.WriteLine ();
                Console.WriteLine ("Digite uma opção");
                Console.WriteLine ("1 - Adicionar Item");
                Console.WriteLine ("2 - Remover Item");
                Console.WriteLine ("3 - Terminar");
                Console.Write ("Opção: ");
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        AddItem (todoList);
                        break;
                    case 2:
                        RemoveItem (todoList);
                        break;
                    case 3:
                        Console.WriteLine ("Tchau!");
                        SaveList(todoList, @filePath);
                        break;
                    default:
                        Console.WriteLine ("Opção Inválida");
                        Console.ReadLine();
                        break;
                }
            } while (opcao != 3);

            return 0;
        }

        static List<TodoItem> initList (string filePath) {
            List<TodoItem> todoList = new List<TodoItem> ();

            try {
                string[] todoFile = File.ReadAllLines (@filePath); //  (File.ReadAllLines) abre o arquivo texto e lê todas as linhas dos arquivos 

                foreach (string line in todoFile) { // foreach vai ler as linhas do seu arquivo
                    string[] itens = line.Split (",");
                    string titulo = itens[0].Replace ("\"", "");
                    string nota = itens[1].Replace ("\"", "");
                    TodoItem todoItem = new TodoItem (titulo, nota);
                    todoList.Add (todoItem); // .Add envia esta variavel ao todo.list
                }

                todoList.RemoveAt (0); // remove a primeira linha do arquivo (cabeçalho no caso)
                return todoList;

            } catch (IOException e) { // comando acionado quando houver erro / ("e" --> VARIAVEL DO METODO IOException)
                Console.WriteLine ("Erro de Acesso.");
                Console.WriteLine (e.Message);
                return null; // utilizzado para abortar a aplicação
            }
        }

        static void ListaItens (List<TodoItem> todoList) {
            Console.Clear ();
            int count = 1;
            Console.WriteLine ("Todo List");
            Console.WriteLine ();
            Console.WriteLine ($"ID{"",2} Titulo{"",12} Notas");
            foreach (TodoItem item in todoList) {
                Console.WriteLine ($"{count,3}: {item.Titulo,-15} - {item.Nota}");
                count++;
            }
        }

        static void AddItem (List<TodoItem> todoList) {
            Console.Clear ();
            Console.WriteLine ("Novo Item");
            Console.WriteLine ();
            Console.Write ("Titulo: ");
            string titulo = Console.ReadLine ();
            Console.Write ("Nota: ");
            string nota = Console.ReadLine ();
            TodoItem item = new TodoItem (titulo, nota);
            todoList.Add (item);
        }
        static void RemoveItem (List<TodoItem> todoList) {
            int index = 0;

            do {
                Console.Clear ();
                Console.WriteLine ("Remove Item");
                Console.WriteLine ();
                ListaItens (todoList);
                Console.WriteLine ();
                Console.WriteLine ("Digite o ID ou x para terminar");
                Console.WriteLine ("ID: ");
                string id = Console.ReadLine ();

                if (id.ToLower () == "x") {
                    break;
                } else {
                    index = int.Parse (id) - 1;
                }

                if ((index < 0) || (index > todoList.Count - 1)) {
                    Console.WriteLine ("ID inválido");
                    Console.WriteLine ("Pressione <enter> para continuar");
                    Console.ReadLine ();
                } else {
                    todoList.RemoveAt (index);
                }
            } while(true);

        }

        static void SaveList (List<TodoItem> lista, string path) {
            List<string> linhas = new List<string> (); //linhas é uma variável da classe List que tem todos os itens de afazeres. é um método construtor pois possui parentes no final
            foreach (TodoItem item in lista) { //foreach para cada item dentro da lista ele vai executar o passo abaixo
                string titulo = "\"" + item.Titulo + "\"";
                string nota = "\"" + item.Nota + "\"";
                linhas.Add (titulo + "," + nota);
            }
            string tryAgain = "n";
            do {
                try {
                    File.WriteAllLines (@path, linhas); //método que vai gravar no disco
                    tryAgain = "n";
                } catch (IOException e) {
                    System.Console.WriteLine ("Erro na leitura do arquivo.");
                    System.Console.WriteLine (e.Message);
                    do {
                        System.Console.WriteLine ("Deseja tentar novamente (S/N) ?");
                        tryAgain = Console.ReadLine ().ToLower ();
                        if ((tryAgain != "n") || (tryAgain != "s")) {
                            System.Console.WriteLine ("Opção inválida");
                        }
                    } while ((tryAgain == "s") || (tryAgain == "n"));
                }
            } while (tryAgain != "n");
        }
    }
}