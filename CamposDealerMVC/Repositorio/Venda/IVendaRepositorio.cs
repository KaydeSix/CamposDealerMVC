using CamposDealerMVC.Models;

namespace CamposDealerMVC.Repositorio.Venda
{
    public interface IVendaRepositorio
    {
        VendaModel AdicionarVenda(VendaModel venda);
        List<VendaModel> ListarTodasVendas();
        VendaModel BuscaVendaById(int IdVenda);
        void ConfirmaAlterarVenda(VendaModel venda);
        void ApagarVenda(int IdVenda);
        string BuscaDscProduto(int idProduto);
        string BuscaNomeCliente(int idCliente);
        List<ClienteModel> ListaTodosClientes();
    }
}
