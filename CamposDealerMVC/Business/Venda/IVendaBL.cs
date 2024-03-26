using CamposDealerMVC.Models;

namespace CamposDealerMVC.Business.Venda
{
    public interface IVendaBL
    {
        ResultadoModel AdicionarVenda(VendaModel Venda);
        List<ViewVendaModel> ListarTodasVendas();
        VendaModel BuscaVendaById(int IdVenda);
        ResultadoModel ConfirmaAlterarVenda(VendaModel Venda);
        ResultadoModel ApagarVenda(int IdVenda);
        List<ClienteModel> ListaTodosClientes();
    }
}
