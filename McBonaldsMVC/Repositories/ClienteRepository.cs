using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ClienteRepository
    {
        private const string PATH = "Database/Cliente.csv"; /// private pois será usado somente nessa classe; coloca o caminho do seu arquivo no qual o File irá buscar
        public ClienteRepository() //construtor que verifica a existencia do arquivo na database
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public bool Inserir (Cliente cliente)
        {
            var linha = new string[] {PrepararRegistroCSV(cliente)};  
            File.AppendAllLines(PATH,linha); // coloca o conteúdo um abaixo do outro.
          
            return true;
        }
        private string PrepararRegistroCSV(Cliente cliente)
        {
            return $"nome={cliente.Nome};email={cliente.Email};senha={cliente.Senha};endereco={cliente.Endereco};telefone={cliente.Telefone};data_nascimento={cliente.DataNascimento}";
        }
    }
}