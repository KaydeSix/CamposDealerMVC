using CamposDealerMVC.Business.Cliente;
using CamposDealerMVC.Models;
using CamposDealerMVC.Repositorio.Cliente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CamposDealerMVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteBL _clienteBL;

        public ClienteController(IClienteBL clienteBL)
        {
            _clienteBL = clienteBL;
        }
        public IActionResult Cliente()
        {
            List<ClienteModel> ListaClientes = _clienteBL.ListarTodosClientes();
            return View(ListaClientes);
        }

        public IActionResult CriarCliente()
        {
            return View();
        }
        public IActionResult EditarCliente(int id)
        {
            ClienteModel cliente = _clienteBL.BuscaClienteById(id);

            return View(cliente);
        }
        public IActionResult ApagarCliente(int id)
        {
            ResultadoModel result = _clienteBL.ApagarCliente(id);

            if (result.Sucesso)
                return RedirectToAction("Cliente");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
        public IActionResult DeletarCliente(int id)
        {
            ClienteModel cliente = _clienteBL.BuscaClienteById(id);

            return View(cliente);
        }
        [HttpPost]
        public IActionResult AdicionarCliente(ClienteModel cliente)
        {
            ResultadoModel result = _clienteBL.AdicionarCliente(cliente);

            if (result.Sucesso)
                return RedirectToAction("Cliente");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
        [HttpPost]
        public IActionResult ConfirmaAlterarCliente(ClienteModel cliente)
        {
            ResultadoModel result = _clienteBL.ConfirmaAlterarCliente(cliente);

            if (result.Sucesso)
                return RedirectToAction("Cliente");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }

        [HttpGet]
        public IActionResult PesquisaClientePeloNome(string data)
        {
            //ResultadoModel result = _clienteBL.ConfirmaAlterarCliente(cliente);

            return Json(true);
        }
    }
}
