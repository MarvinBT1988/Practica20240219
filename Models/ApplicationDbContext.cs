using Microsoft.EntityFrameworkCore;
namespace Practica20240219.Models;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Agrega DbSet para cada entidad que desees mapear
    public DbSet<Categoria> Categorias { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aquí puedes configurar relaciones, claves primarias, etc.
    }
}
