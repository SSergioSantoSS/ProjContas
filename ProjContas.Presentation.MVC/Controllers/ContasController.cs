using Microsoft.AspNetCore.Mvc;

namespace ProjContas.Presentation.MVC.Controllers
{

    public class ContasController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Consulta()
        {
            return View();
        }
    }


}
