using Microsoft.EntityFrameworkCore;

namespace BE_CRUDClientes.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

    }
}
