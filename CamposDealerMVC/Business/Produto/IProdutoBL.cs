using CamposDealerMVC.Models;

namespace CamposDealerMVC.Business.Produto
{
    public interface IProdutoBL
    {
        ResultadoModel AdicionarProduto(ProdutoModel produto);
        List<ProdutoModel> ListarTodosProdutos();
        ProdutoModel BuscaProdutoById(int IdProduto);
        ResultadoModel ConfirmaAlterarProduto(ProdutoModel produto);
        ResultadoModel ApagarProduto(int IdProduto);
    }
}
