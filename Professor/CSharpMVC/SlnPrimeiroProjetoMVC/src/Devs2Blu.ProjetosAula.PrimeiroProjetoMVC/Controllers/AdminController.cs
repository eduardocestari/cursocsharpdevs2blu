using Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Devs2Blu.ProjetosAula.PrimeiroProjetoMVC.Controllers
{
    [Route("admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            List<User> users = new List<User>()
            //ar user = new User
            {
                new User {  Id = 1, Name = "Eduardo Augusto Cestari", Login = "Eduardo.Cestari"},
                new User { Id = 2, Name = "Eduardo Augusto Cestari 2", Login = "Eduardo.Cestari2" }
            };
            return View(users);
        }

        [Route("indicadores")]    
        [Route("numbers")]    
        public IActionResult Indicadores()
        {
            return View();
        }

        [Route("cards")]
        public PartialViewResult CardsResultados()
        {
            //var result = Service.GetLista();
            return PartialView();
        }
    }
}
