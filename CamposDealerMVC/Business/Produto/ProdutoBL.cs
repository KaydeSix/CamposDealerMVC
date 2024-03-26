using CamposDealerMVC.Models;
using CamposDealerMVC.Repositorio.Cliente;
using CamposDealerMVC.Repositorio.Produto;

namespace CamposDealerMVC.Business.Produto
{
    public class ProdutoBL : IProdutoBL
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoBL(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
        public ResultadoModel AdicionarProduto(ProdutoModel produto)
        {
            try
            {
                _produtoRepositorio.AdicionarProduto(produto);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao adicionar o produto. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Produto adicionado com sucesso!" };
        }
        public List<ProdutoModel> ListarTodosProdutos()
        {
            return _produtoRepositorio.ListarTodosProdutos();
        }
        public ProdutoModel BuscaProdutoById(int IdProduto)
        {
            return _produtoRepositorio.BuscaProdutoById(IdProduto);
        }
        public ResultadoModel ConfirmaAlterarProduto(ProdutoModel produto)
        {
            try
            {
                _produtoRepositorio.ConfirmaAlterarProduto(produto);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao alterar o produto. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Produto alterado com sucesso!" };
        }
        public ResultadoModel ApagarProduto(int IdProduto)
        {
            try
            {
                _produtoRepositorio.ApagarProduto(IdProduto);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao remover produto. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Produto removido com sucesso!" };
        }
    }
}
