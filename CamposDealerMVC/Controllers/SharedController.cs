using CamposDealerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CamposDealerMVC.Controllers
{
    public class SharedController : Controller
    {
        public IActionResult ViewErro(ResultadoModel erro)
        {
            return View(erro);
        }
    }
}
