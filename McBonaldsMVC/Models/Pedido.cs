using System;
using McBonaldsMVC.Enums;

namespace McBonaldsMVC.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente Cliente{get;set;}
        public Hamburguer Hamburguer{get;set;}
        public Shake Shake{get;set;}
        public DateTime DataDoPedido {get;set;}
        public double PrecoTotal {get;set;}
        public uint Status { get;set;}
        public Pedido()
        {
            this.Cliente = new Cliente(); // referencia para cliente
            this.Hamburguer = new Hamburguer();//referencia para hamburguer -- é necessário dar new no objeto para existir uma objeto. No momento em que é acessado "Pedido"
            this.Shake = new Shake();// referencia para shake
            this.Id = 0;
            this.Status = (uint) StatusPedido.PENDENTE;
        }

    }
}