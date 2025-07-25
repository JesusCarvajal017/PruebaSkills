
using Entity.Model.Pizza;
using Microsoft.EntityFrameworkCore;

namespace Entity.Context.Main
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options ) : base (options)
        {
                    
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Usuario> Usuario { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica tu configuración que implementen IEntityTypeConfiguration<T>
      


            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicationDbContext).Assembly);
        }


    }
}
