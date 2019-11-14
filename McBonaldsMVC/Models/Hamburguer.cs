namespace McBonaldsMVC.Models
{
    public class Hamburguer : Produto  // o modelo define um conjunto de características do que você descreve
    {
        public Hamburguer()
        {

        }

        public Hamburguer(string nome,double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}