using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CamposDealerMVC.Models
{
    public class VendaModel
    {
        [Key]
        [Required]
        [Column("ID_VENDA")]
        public int IdVenda { get; set; }

        [Required]
        [ForeignKey("ClienteModel")]
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }

        [Required]
        [ForeignKey("ProdutoModel")]
        [Column("ID_PRODUTO")]
        public int IdProduto { get; set; }

        [Required]
        [Column("QTD_VENDA")]
        public long QtdVenda { get; set; }

        [Required]
        [Column("VLR_UNITARIO_VENDA")]
        public long VlrUnitarioVenda { get; set; }

        [Required]
        [Column("DATA_VENDA")]
        public DateTime DataVenda { get; set; }

        [Required]
        [Column("VLR_TOTAL_VENDA")]
        public float VlrTotalVenda { get; set; }

        public ClienteModel ClienteModel { get; set; }
        public ProdutoModel ProdutoModel { get; set; }

    }
}
