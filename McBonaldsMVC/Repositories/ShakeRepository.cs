using System.Collections.Generic;
using System.IO;
using McBonaldsMVC.Models;

namespace McBonaldsMVC.Repositories
{
    public class ShakeRepository
    {
        private const string PATH = "Database/Shake.csv";
        
        public double ObterPrecoDe(string nomeShake)
        {
            var lista = ObterTodos();
            double preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(nomeShake))
                {
                     preco = item.Preco;
                     break;
                }
            }
            return preco;
        }
        public List<Shake> ObterTodos()

        {
            List<Shake> shakes = new List<Shake>();


          string[] linhas= File.ReadAllLines(PATH);
          foreach (var linha in linhas) // para cada linha de "linhas"
          {
              Shake x = new Shake();
              string[] dados = linha.Split(";");
              x.Nome = dados[0];  // irá verificar o valor de cada linha da lista
              x.Preco = double.Parse(dados[1]);
              shakes.Add(x); //passa os dados para sua lista
          }
          return shakes;
        }
    }
}