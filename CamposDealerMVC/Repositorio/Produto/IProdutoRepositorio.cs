using CamposDealerMVC.Models;

namespace CamposDealerMVC.Repositorio.Produto
{
    public interface IProdutoRepositorio
    {
        ProdutoModel AdicionarProduto(ProdutoModel produto);
        List<ProdutoModel> ListarTodosProdutos();
        ProdutoModel BuscaProdutoById(int IdProduto);
        void ConfirmaAlterarProduto(ProdutoModel produto);
        void ApagarProduto(int IdProduto);
    }
}
