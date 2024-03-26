using CamposDealerMVC.Models;

namespace CamposDealerMVC.Repositorio.Cliente
{
    public interface IClienteRepositorio
    {
        ClienteModel AdicionarCliente(ClienteModel cliente);
        List<ClienteModel> ListarTodosClientes();
        ClienteModel BuscaClienteById(int IdCliente);
        VendaModel BuscaVendaByIdCliente(int IdCliente);
        void ConfirmaAlterarCliente(ClienteModel cliente);
        void ApagarCliente(int IdCliente);
    }
}
