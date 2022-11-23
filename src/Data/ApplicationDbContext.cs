using Microsoft.EntityFrameworkCore;
using team_shirt.Models;

namespace team_shirt.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<team_shirt.Models.Produto> Produto { get; set; }

        public DbSet<team_shirt.Models.Categoria> Categoria { get; set; }
    }
}
