using System;
using McBonaldsMVC.Models;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class PedidoController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();
        HamburguerRepository hamburguerRepository = new HamburguerRepository();
        ShakeRepository shakeRepository = new ShakeRepository();

        ClienteRepository clienteRepository = new ClienteRepository();
       public IActionResult Index()
       {
           var hamburguer = hamburguerRepository.ObterTodos();
           PedidoViewModel pedido = new PedidoViewModel();
           pedido.Hamburgueres = hamburguer; 
           pedido.Shakes = shakeRepository.ObterTodos();

           var usuarioLogado = ObterUsuarioSession();
           var nomeUsuarioLogado = ObterUsuarioNomeSession();
           if(!string.IsNullOrEmpty(nomeUsuarioLogado)){
               pedido.NomeUsuario = nomeUsuarioLogado;
           }

            var clienteLogado = clienteRepository.ObterPor(usuarioLogado);
            if(clienteLogado != null)
            {
                pedido.Cliente = clienteLogado;
            }
            pedido.NomeView = "Pedido";
            pedido.UsuarioEmail = ObterUsuarioSession();
            pedido.UsuarioNome = ObterUsuarioNomeSession();
           return View(pedido);
       }




       public IActionResult Registrar(IFormCollection form)
       {
           ViewData["Action"] = "Pedido";

           Pedido pedido = new Pedido();
           Shake shake = new Shake();
           shake.Nome = form["shake"];
           shake.Preco = shakeRepository.ObterPrecoDe(form["shake"]);

           pedido.Shake = shake;

            Hamburguer hamburguer = new Hamburguer(form["hamburguer"],hamburguerRepository.ObterPrecoDe(form["hamburguer"]));// método retorna um double 

            pedido.Hamburguer = hamburguer;

           Cliente cliente = new Cliente()
           {
               Nome = form["nome"],
               Endereco = form["endereco"],
               Telefone = form["telefone"],
               Email = form["email"],
           };


           pedido.Cliente = cliente;

           pedido.DataDoPedido = DateTime.Now;

           pedido.PrecoTotal = hamburguer.Preco + shake.Preco;

            if(pedidoRepository.Inserir(pedido)) {
           return View("Sucesso", new RespostaViewModel()
            {

                Mensagem = "Aguarde a aprovação dos nossos administradores",
                NomeView = "Sucesso",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
            } else {
                return View ("Erro", new RespostaViewModel()
                {
                    Mensagem = "Houve um erro ao procurar seu pedido. Tente novamente!",
                    NomeView = "Erro",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
       }
    }
}