using System;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories {
    public class ClienteRepository {
        private const string PATH = "Database/Cliente.csv"; /// private pois será usado somente nessa classe; coloca o caminho do seu arquivo no qual o File irá buscar
        public ClienteRepository () //construtor que verifica a existencia do arquivo na database
        {
            if (!File.Exists (PATH)) {
                File.Create (PATH).Close ();
            }
        }
        public bool Inserir (Cliente cliente) {
            var linha = new string[] { PrepararRegistroCSV (cliente) };
            File.AppendAllLines (PATH, linha); // coloca o conteúdo um abaixo do outro.

            return true;
        }
        public Cliente ObterPor (string email) {
            var linhas = File.ReadAllLines (PATH);
            foreach (var linha in linhas) {
                if (ExtrairValorDoCampo ("email", linha).Equals (email)) {
                    Cliente c = new Cliente ();
                    c.Nome = ExtrairValorDoCampo ("nome", linha);
                    c.Email = ExtrairValorDoCampo ("email", linha);
                    c.Senha = ExtrairValorDoCampo ("senha", linha);
                    c.Endereco = ExtrairValorDoCampo ("endereco", linha);
                    c.Telefone = ExtrairValorDoCampo ("telefone", linha);
                    c.DataNascimento = DateTime.Parse (ExtrairValorDoCampo ("data_nascimento", linha));

                    return c;
                }
            }
            return null;
        }
        private string PrepararRegistroCSV (Cliente cliente) {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }
        public string ExtrairValorDoCampo (string nomeCampo, string linha) {
            var chave = nomeCampo;
            var indiceChave = linha.IndexOf (chave);

            var indiceTerminal = linha.IndexOf (";", indiceChave);
            var valor = "";

            if (indiceTerminal != -1) {
                valor = linha.Substring (indiceChave, indiceTerminal - indiceChave);
            } else {
                valor = linha.Substring (indiceChave);
            }
            System.Console.WriteLine ($"Campo {nomeCampo} tem valor {valor}");
            return valor.Replace (nomeCampo + "=", "");

        }
    }
}