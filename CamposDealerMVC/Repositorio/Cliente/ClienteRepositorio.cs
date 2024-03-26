using CamposDealerMVC.Business.Cliente;
using CamposDealerMVC.DataAcces;
using CamposDealerMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CamposDealerMVC.Repositorio.Cliente
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public ClienteModel AdicionarCliente(ClienteModel cliente)
        {
            _bancoContext.CLIENTE.Add(cliente);
            _bancoContext.SaveChanges();

            return cliente;
        }
        public List<ClienteModel> ListarTodosClientes()
        {
            return _bancoContext.CLIENTE.ToList();
            //return _bancoContext.CLIENTE.FromSqlRaw($"SELECT * FROM CLIENTE").ToList();
        }
        public ClienteModel BuscaClienteById(int IdCliente)
        {
            return _bancoContext.CLIENTE.FirstOrDefault(x => x.IdCliente == IdCliente);
        }

        public void ConfirmaAlterarCliente(ClienteModel cliente)
        {
            ClienteModel clienteBanco = BuscaClienteById(cliente.IdCliente);

            clienteBanco.Cidade = cliente.Cidade;
            clienteBanco.Email = cliente.Email;
            clienteBanco.Nome = cliente.Nome;

            _bancoContext.CLIENTE.Update(clienteBanco);
            _bancoContext.SaveChanges();
        }

        public void ApagarCliente(int idCliente)
        {
            ClienteModel clienteBanco = BuscaClienteById(idCliente);

            _bancoContext.CLIENTE.Remove(clienteBanco);
            _bancoContext.SaveChanges();
        }
        public VendaModel BuscaVendaByIdCliente(int IdCliente)
        {
            return _bancoContext.VENDA.FirstOrDefault(x => x.IdCliente == IdCliente);
        }
    }
}
