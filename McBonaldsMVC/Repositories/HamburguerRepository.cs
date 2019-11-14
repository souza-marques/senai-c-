using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class HamburguerRepository
    {
        private const string PATH = "Database/Hamburguer";
        public HamburguerRepository()
        {
            if(!File.Exist(PATH))
            {
                File.Create(PATH).Close();
            }
        }

        public List<Hamburguer> ObterTodos()
        {
            List<Hamburguer>hamburgueres = new List<Hamburguer>();
          string[] linhas= File.ReadAllLines(PATH);
          foreach (var linha in linhas)
          {
              Hamburguer h = new Hamburguer();
              string[] dados = linha.Split(";");
              h.Nome = dados[0];
              h.Preco = double.Parse(dados[1]);
              hamburgueres.Add(h); //passa os dados para sua lista
          }
          return hamburgueres;
        }
    }
}