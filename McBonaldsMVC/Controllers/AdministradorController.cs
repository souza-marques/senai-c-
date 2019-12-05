using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers
{
    public class AdministradorController : AbstractController
    {
        PedidoRepository pedidoRepository = new PedidoRepository();

        [HttpGet]  //marcar as requisições que chegaram para essa classe  são do tipo Get
        public IActionResult Dashboard()
        {

           var tipoUsuarioSessao = uint.Parse(ObterUsuarioSession());
            if (tipoUsuarioSessao.Equals((uint)TiposUsuario.ADMINISTRADOR))
            {

           var pedidos = pedidoRepository.ObterTodos();
           DashboardViewModel dashboardViewModel = new DashboardViewModel();

           foreach( var pedido in pedidos)
           {
               switch (pedido.Status)
               {
                   case (uint) StatusPedido.REPROVADO:
                   dashboardViewModel.PedidosPendentes++;
                
                   break;
                   case (uint) StatusPedido.APROVADO:
                   dashboardViewModel.PedidosAprovados++;
                   break;
                   default:
                   dashboardViewModel.PedidosPendentes++;
                   dashboardViewModel.Pedidos.Add(pedido);
                   break;
               }
           }
           dashboardViewModel.NomeView = "Dashboard";
           dashboardViewModel.UsuarioEmail = ObterUsuarioNomeSession();

           return View(dashboardViewModel);
            }
        
           return View("Erro", new RespostaViewModel()
           {
            NomeView = "Dashboard",
            Mensagem = "Acesso restrito"
           });

        }
    }
} 