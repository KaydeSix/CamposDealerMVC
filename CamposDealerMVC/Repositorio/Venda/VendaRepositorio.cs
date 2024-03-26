using CamposDealerMVC.DataAcces;
using CamposDealerMVC.Models;

namespace CamposDealerMVC.Repositorio.Venda
{
    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly BancoContext _bancoContext;
        public VendaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public VendaModel AdicionarVenda(VendaModel venda)
        {
            _bancoContext.VENDA.Add(venda);
            _bancoContext.SaveChanges();

            return venda;
        }
        public List<VendaModel> ListarTodasVendas()
        {
            return _bancoContext.VENDA.ToList();
        }
        public VendaModel BuscaVendaById(int IdVenda)
        {
            return _bancoContext.VENDA.FirstOrDefault(x => x.IdVenda == IdVenda);
        }

        public void ConfirmaAlterarVenda(VendaModel venda)
        {
            VendaModel vendaBanco = BuscaVendaById(venda.IdVenda);

            vendaBanco.QtdVenda = venda.QtdVenda;
            vendaBanco.DataVenda = venda.DataVenda;
            vendaBanco.VlrTotalVenda = venda.VlrTotalVenda;
            vendaBanco.VlrUnitarioVenda = venda.VlrUnitarioVenda;
            vendaBanco.IdCliente = venda.IdCliente;
            vendaBanco.IdProduto = venda.IdProduto;

            _bancoContext.VENDA.Update(vendaBanco);
            _bancoContext.SaveChanges();
        }

        public void ApagarVenda(int idVenda)
        {
            VendaModel vendaBanco = BuscaVendaById(idVenda);

            _bancoContext.VENDA.Remove(vendaBanco);
            _bancoContext.SaveChanges();
        }
        public string BuscaDscProduto(int idProduto)
        {
            ProdutoModel produto = _bancoContext.PRODUTO.FirstOrDefault(x => x.IdProduto == idProduto);

            return produto.Descricao;
        }
        public string BuscaNomeCliente(int idCliente)
        {
            ClienteModel cliente = _bancoContext.CLIENTE.FirstOrDefault(x => x.IdCliente == idCliente);

            return cliente.Nome;
        }
        public List<ClienteModel> ListaTodosClientes()
        {
            return _bancoContext.CLIENTE.ToList();
        }
    }
}
