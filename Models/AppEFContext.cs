using Microsoft.EntityFrameworkCore;

namespace AppEF.Models
{
    public class AppEFContext: DbContext
    {
        public DbSet<Producto> Productos
        {
            get;
            set;
        }

        public DbSet<Cliente> Clientes
        {
            get;
            set;
        }

        public AppEFContext(DbContextOptions<AppEFContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var clientesInit = new List<Cliente>()
            {
                new Cliente(1, "Juan", "juan@gmail.com", "1234567890"),
                new Cliente(2, "Pedro", "pedro@gmail.com", "1234567890"),
                new Cliente(3, "Maria", "maria@gmail.com", "1234567890"),
                new Cliente(4, "Luis", "luis@gmail.com", "1234567890")
            };

            var productosInit = new List<Producto>()
            {
                new Producto(1, "Producto 1", "Descripcion 1", 100.00),
                new Producto(2, "Producto 2", "Descripcion 2", 200.00),
                new Producto(3, "Producto 3", "Descripcion 3", 300.00),
                new Producto(4, "Producto 4", "Descripcion 4", 400.00),
                new Producto(5, "Producto 5", "Descripcion 5", 500.00)
            };

            modelBuilder.Entity<Cliente>(c =>
            {
                c.ToTable("Cliente");

                c.HasKey(c => c.ClienteId);

                //c.Property(c => c.Nombre);
                //c.Property(c => c.Email);
                //c.Property(c => c.Numero);

                c.HasData(clientesInit);
            });

            modelBuilder.Entity<Producto>(p =>
            {
                p.ToTable("Producto");

                p.HasKey(p => p.ProductoId);

                //p.Property(p => p.Nombre);
                //p.Property(p => p.Descripcion);
                //p.Property(p => p.Precio);

                p.HasData(productosInit);
            });
        }
    }
}
