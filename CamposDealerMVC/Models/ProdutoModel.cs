using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamposDealerMVC.Models
{
    public class ProdutoModel
    {
        [Key]
        [Required]
        [Column("ID_PRODUTO")]
        public int IdProduto { get; set; }
        [Required]
        [Column("DESCRICAO_PRODUTO")]
        [MinLength(10)]
        [MaxLength(200)]
        public string Descricao { get; set; }
        [Required]
        [Column("VALOR_UNITARIO")]
        public float VlrUnitario { get; set; }
    }
}
