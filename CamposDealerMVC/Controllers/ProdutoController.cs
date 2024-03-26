using CamposDealerMVC.Business.Cliente;
using CamposDealerMVC.Business.Produto;
using CamposDealerMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CamposDealerMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoBL _produtoBL;

        public ProdutoController(IProdutoBL produtoBL)
        {
            _produtoBL = produtoBL;
        }
        public IActionResult Produto()
        {
            List<ProdutoModel> ListaProdutos = _produtoBL.ListarTodosProdutos();
            return View(ListaProdutos);
        }

        public IActionResult CriarProduto()
        {
            return View();
        }
        public IActionResult EditarProduto(int id)
        {
            ProdutoModel produto = _produtoBL.BuscaProdutoById(id);

            return View(produto);
        }
        public IActionResult ApagarProduto(int id)
        {
            ResultadoModel result = _produtoBL.ApagarProduto(id);

            if (result.Sucesso)
                return RedirectToAction("Produto");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
        public IActionResult DeletarProduto(int id)
        {
            ProdutoModel produto = _produtoBL.BuscaProdutoById(id);

            return View(produto);
        }
        [HttpPost]
        public IActionResult AdicionarProduto(ProdutoModel produto)
        {
            ResultadoModel result = _produtoBL.AdicionarProduto(produto);

            if (result.Sucesso)
                return RedirectToAction("Produto");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
        [HttpPost]
        public IActionResult ConfirmaAlterarProduto(ProdutoModel produto)
        {
            ResultadoModel result = _produtoBL.ConfirmaAlterarProduto(produto);

            if (result.Sucesso)
                return RedirectToAction("Produto");
            else
                return RedirectToAction("ViewErro", "Shared", result);
        }
    }
}
