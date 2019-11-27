using Microsoft.AspNetCore.Mvc;
using RoleTopMVC.ViewModels;

namespace RoleTopMVC.Controllers
{
    public class OrcamentoController : Controller
    {
           public IActionResult  CadastroEventos()
           {
              return View (new BaseViewModel()
              {
                  NomeView = "Orcamento"
              });
           }
    }
}