using Microsoft.EntityFrameworkCore;
using WebProjeto.Models;

namespace WebProjeto.Data
{
    public class BancoContext: DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ContatoModel> Contatos { get; set; }

    }
}
