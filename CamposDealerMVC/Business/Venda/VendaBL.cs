using CamposDealerMVC.Models;
using CamposDealerMVC.Repositorio.Venda;

namespace CamposDealerMVC.Business.Venda
{
    public class VendaBL : IVendaBL
    {
        private readonly IVendaRepositorio _vendaRepositorio;

        public VendaBL(IVendaRepositorio vendaRepositorio)
        {
            _vendaRepositorio = vendaRepositorio;
        }
        public ResultadoModel AdicionarVenda(VendaModel venda)
        {
            try
            {
                venda.VlrTotalVenda = venda.VlrUnitarioVenda * venda.QtdVenda;

                _vendaRepositorio.AdicionarVenda(venda);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao adicionar a venda. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Venda adicionada com sucesso!" };
        }
        public List<ViewVendaModel> ListarTodasVendas()
        {
            List<ViewVendaModel> VendasTela = new List<ViewVendaModel>();
            List<VendaModel> VendasBanco = _vendaRepositorio.ListarTodasVendas();

            foreach(VendaModel item in VendasBanco)
            {
                string nomeCliente = _vendaRepositorio.BuscaNomeCliente(item.IdCliente);
                string dscProduto = _vendaRepositorio.BuscaDscProduto(item.IdProduto);

                ViewVendaModel Venda = new ViewVendaModel
                {
                    IdProduto = item.IdProduto,
                    IdCliente = item.IdCliente,
                    VlrTotalVenda = item.VlrTotalVenda,
                    VlrUnitarioVenda = item.VlrUnitarioVenda,
                    QtdVenda = item.QtdVenda,
                    DataVenda = item.DataVenda,
                    NomeCliente = nomeCliente,
                    DscProduto = dscProduto,
                };
                VendasTela.Add(Venda);
            }

            return VendasTela;
        }
        public VendaModel BuscaVendaById(int IdVenda)
        {
            return _vendaRepositorio.BuscaVendaById(IdVenda);
        }
        public ResultadoModel ConfirmaAlterarVenda(VendaModel venda)
        {
            try
            {
                _vendaRepositorio.ConfirmaAlterarVenda(venda);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao alterar o venda. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Venda alterado com sucesso!" };
        }
        public ResultadoModel ApagarVenda(int IdVenda)
        {
            try
            {
                _vendaRepositorio.ApagarVenda(IdVenda);
            }
            catch (Exception ex)
            {
                return new ResultadoModel { Sucesso = false, Mensagem = $"Erro ao remover venda. Erro: {ex}" };
            }

            return new ResultadoModel { Sucesso = true, Mensagem = "Venda removido com sucesso!" };
        }
        public List<ClienteModel> ListaTodosClientes()
        {
            return _vendaRepositorio.ListaTodosClientes();
        }
    }
}
