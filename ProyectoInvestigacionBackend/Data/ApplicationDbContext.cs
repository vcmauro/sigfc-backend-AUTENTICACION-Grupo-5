using Microsoft.EntityFrameworkCore;
using ProyectoInvestigacionBackend.Models;

namespace ProyectoInvestigacionBackend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}