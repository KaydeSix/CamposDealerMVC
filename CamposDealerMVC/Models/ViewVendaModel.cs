using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamposDealerMVC.Models
{
    public class ViewVendaModel
    {
        public int IdVenda { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public int IdProduto { get; set; }
        public string DscProduto { get; set; }
        public long QtdVenda { get; set; }
        public long VlrUnitarioVenda { get; set; }
        public DateTime DataVenda { get; set; }
        public float VlrTotalVenda { get; set; }
    }
}
