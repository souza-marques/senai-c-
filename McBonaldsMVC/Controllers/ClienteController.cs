using System;
using McBonaldsMVC.Enums;
using McBonaldsMVC.Repositories;
using McBonaldsMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace McBonaldsMVC.Controllers {
    public class ClienteController : AbstractController
     {
       
       private ClienteRepository clienteRepository = new ClienteRepository();
       private PedidoRepository pedidoRepository = new PedidoRepository();
       
        [HttpGet]
        public IActionResult Login () {
            return View ( new BaseViewModel()
            {
                NomeView = "Login",
                UsuarioEmail = ObterUsuarioNomeSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }

        [HttpPost]
        public IActionResult Login (IFormCollection form) {
            ViewData["Action"] = "Login";
            try {
                System.Console.WriteLine ("=========================");
                System.Console.WriteLine (form["email"]);
                System.Console.WriteLine (form["senha"]);
                System.Console.WriteLine ("=========================");

                var usuario = form["email"];
                var senha = form["senha"];

                var cliente = clienteRepository.ObterPor(usuario);

                if(cliente !=null ) // se o cliente for diferente de nulo 
                {
                    if(cliente.Senha.Equals(senha))
                    {
                        switch (cliente.TipoUsuario)
                        {
                            case (uint) TiposUsuario.CLIENTE:
                             HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                             HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                              HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                             return RedirectToAction("Historico","Cliente");
                       
                          default:
                             HttpContext.Session.SetString(SESSION_CLIENTE_EMAIL, usuario);
                             HttpContext.Session.SetString(SESSION_CLIENTE_NOME, cliente.Nome);
                             HttpContext.Session.SetString(SESSION_TIPO_USUARIO, cliente.TipoUsuario.ToString());
                               return RedirectToAction("Dasboard","Administrador");
                        }
                    }
                    else
                    {
                        return View("Erro",new RespostaViewModel("Senha incorreta"));
                    }
                } 
                else 
                {
                    return View("Erro", new RespostaViewModel($"Usuário {usuario} não foi encontrado"));// criando objeto sem guardá-lo ao "clientecontroller"
                }

            } catch (Exception e) {
                System.Console.WriteLine (e.StackTrace);
                return View ("Erro");
            }

        }
    
        public IActionResult Historico()
        {
            var emailCliente = ObterUsuarioSession();
            var pedidos = pedidoRepository.ObterTodosPorCliente(emailCliente);

            return View(new HistoricoViewModel()
            {
            Pedidos = pedidos,
            NomeView = "Histórico",
            UsuarioNome = ObterUsuarioNomeSession(),
            UsuarioEmail = ObterUsuarioSession()

            });
        }

        public IActionResult Logoff()
        {
            HttpContext.Session.Remove(SESSION_CLIENTE_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE_NOME);
            HttpContext.Session.Clear();
            return RedirectToAction ("Index", "Home");
        }
    }
}