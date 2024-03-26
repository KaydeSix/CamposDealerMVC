using CamposDealerMVC.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace CamposDealerMVC.DataAcces
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) { }

        public DbSet<ClienteModel> CLIENTE { get; set; }
        public DbSet<ProdutoModel> PRODUTO { get; set; }
        public DbSet<VendaModel> VENDA { get; set; }
    }
}
