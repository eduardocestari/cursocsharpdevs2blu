using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    public class GaleriaController : Controller
    {
        [Route("galeria")]
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Galeria()
        {
            return View();
        }

        public IActionResult Carousel()
        {
            return View();
        }
    }
}
