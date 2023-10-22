using Microsoft.EntityFrameworkCore;
using Bowler.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Bowler.API.Data
{
    public class DataContext : IdentityDbContext<User>
    { 
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }

        public DbSet<Reserva>Reservas { get; set; }
        public DbSet<Pago>Pagos { get; set; }
        public DbSet<Producto>Productos { get; set; }
        public DbSet<Pista>Pistas { get; set; }
        public DbSet<Evento>Eventos { get; set; }
        public DbSet<Promocion>Promociones { get; set; }
        public DbSet<Role>Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User>Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reserva>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Pago>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Producto>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Pista>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Evento>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Promocion>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Role>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<UserRole>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<User>().HasIndex(c => c.Document).IsUnique();
        }
    }
}
