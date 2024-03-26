using CamposDealerMVC.Models;

namespace CamposDealerMVC.Business.Cliente
{
    public interface IClienteBL
    {
        ResultadoModel AdicionarCliente(ClienteModel cliente);
        List<ClienteModel> ListarTodosClientes();
        ClienteModel BuscaClienteById (int IdCliente);
        ResultadoModel ConfirmaAlterarCliente(ClienteModel Cliente);
        ResultadoModel ApagarCliente(int IdCliente);
    }
}
