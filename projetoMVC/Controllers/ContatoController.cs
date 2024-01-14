using Microsoft.AspNetCore.Mvc;

namespace projetoMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
    }
}