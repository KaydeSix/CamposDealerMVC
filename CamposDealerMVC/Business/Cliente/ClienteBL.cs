using CamposDealerMVC.Models;
using CamposDealerMVC.Repositorio.Cliente;

namespace CamposDealerMVC.Business.Cliente
{
    public class ClienteBL :IClienteBL
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteBL(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }
        public ResultadoModel AdicionarCliente(ClienteModel cliente)
        {
            try
            {
                _clienteRepositorio.AdicionarCliente(cliente);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao adicionar o cliente. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Cliente adicionado com sucesso!"};
        }
        public List<ClienteModel> ListarTodosClientes()
        {
            return _clienteRepositorio.ListarTodosClientes();
        }
        public ClienteModel BuscaClienteById(int IdCliente)
        {
            return _clienteRepositorio.BuscaClienteById(IdCliente);
        }
        public ResultadoModel ConfirmaAlterarCliente(ClienteModel cliente)
        {
            try
            {
                _clienteRepositorio.ConfirmaAlterarCliente(cliente);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao alterar o cliente. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Cliente alterado com sucesso!" };
        }
        public ResultadoModel ApagarCliente(int IdCliente)
        {
            try
            {
                VendaModel venda = _clienteRepositorio.BuscaVendaByIdCliente(IdCliente);

                if (venda.IdVenda > 0)
                {
                    return new ResultadoModel { Sucesso = false, Mensagem = $"Esse Cliente não pode ser removido por pertencer a uma venda! Por favor verifique a tela de vendas." };
                }

                _clienteRepositorio.ApagarCliente(IdCliente);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao remover cliente. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Cliente removido com sucesso!" };
        }
    }
}
