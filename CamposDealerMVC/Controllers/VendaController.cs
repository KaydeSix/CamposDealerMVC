using CamposDealerMVC.Business.Venda;
using CamposDealerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CamposDealerMVC.Controllers
{
    public class VendaController : Controller
    {
        private readonly IVendaBL _vendaBL;

        public VendaController(IVendaBL vendaBL)
        {
            _vendaBL = vendaBL;
        }
        public IActionResult Venda()
        {
            List<ViewVendaModel> ListaVendas = _vendaBL.ListarTodasVendas();
            return View(ListaVendas);
        }

        public IActionResult CriarVenda()
        {
            ViewBag.Clientes = _vendaBL.ListaTodosClientes();                             
          
            return View();
        }
        public IActionResult EditarVenda(int id)
        {
            VendaModel venda = _vendaBL.BuscaVendaById(id);

            return View(venda);
        }
        public IActionResult ApagarVenda(int id)
        {
            ResultadoModel result = _vendaBL.ApagarVenda(id);

            if (result.Sucesso)
                return RedirectToAction("Venda");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
        public IActionResult DeletarVenda(int id)
        {
            VendaModel venda = _vendaBL.BuscaVendaById(id);

            return View(venda);
        }
        [HttpPost]
        public IActionResult AdicionarVenda(VendaModel venda)
        {
            ResultadoModel result = _vendaBL.AdicionarVenda(venda);

            if (result.Sucesso)
                return RedirectToAction("Venda");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
        [HttpPost]
        public IActionResult ConfirmaAlterarVenda(VendaModel venda)
        {
            ResultadoModel result = _vendaBL.ConfirmaAlterarVenda(venda);

            if (result.Sucesso)
                return RedirectToAction("Venda");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
    }
}
