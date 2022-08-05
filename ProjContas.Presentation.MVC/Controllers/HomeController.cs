using Microsoft.AspNetCore.Mvc;

namespace ProjContas.Presentation.MVC.Controllers
{
    public class HomeController : Controller
    {
        //GET: /Home/Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
