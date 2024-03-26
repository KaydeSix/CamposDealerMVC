using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CamposDealerMVC.Models
{
    public class ClienteModel
    {
        [Key]
        [Required]
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Required]
        [Column("NOME")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Nome { get; set; }
        [Required]
        [Column("CIDADE")]
        [MinLength(3)]
        [MaxLength(100)]
        public string Cidade { get; set; }
        [Required]
        [Column("EMAIL")]
        [MinLength(6)]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
