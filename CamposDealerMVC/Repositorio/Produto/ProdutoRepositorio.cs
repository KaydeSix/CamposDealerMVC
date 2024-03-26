using CamposDealerMVC.DataAcces;
using CamposDealerMVC.Models;

namespace CamposDealerMVC.Repositorio.Produto
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ProdutoModel AdicionarProduto(ProdutoModel produto)
        {
            _bancoContext.PRODUTO.Add(produto);
            _bancoContext.SaveChanges();

            return produto;
        }
        public List<ProdutoModel> ListarTodosProdutos()
        {
            return _bancoContext.PRODUTO.ToList();
        }
        public ProdutoModel BuscaProdutoById(int IdProduto)
        {
            return _bancoContext.PRODUTO.FirstOrDefault(x => x.IdProduto == IdProduto);
        }

        public void ConfirmaAlterarProduto(ProdutoModel produto)
        {
            ProdutoModel produtoBanco = BuscaProdutoById(produto.IdProduto);

            produtoBanco.Descricao = produto.Descricao;
            produtoBanco.VlrUnitario = produto.VlrUnitario;

            _bancoContext.PRODUTO.Update(produtoBanco);
            _bancoContext.SaveChanges();
        }

        public void ApagarProduto(int idProduto)
        {
            ProdutoModel produtoBanco = BuscaProdutoById(idProduto);

            _bancoContext.PRODUTO.Remove(produtoBanco);
            _bancoContext.SaveChanges();
        }
    }
}
