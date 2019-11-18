using McBonaldsMVC.Models;
using System.Collections.Generic;

namespace McBonaldsMVC.ViewModels

{
    public class PedidoViewModel
    {
        public List<Hamburguer> Hamburgueres {get;set;}
        public List<Shake> Shakes {get;set;}

      
      public PedidoViewModel()
      {
          this.Hamburgueres = new List<Hamburguer>(); // construtor para inicializar a lista
          this.Shakes = new List<Shake>();
      }
      
    }
}