using DropDownsAnidadosMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DropDownsAnidadosMVC.Data;

public class ApplicationDbContext: DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options)
    {
    }
    // AGREGAMOS LOS MODELOS
    public DbSet<Sucursal> Sucursal { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Producto> Producto { get; set; }
    
    // SEEDING
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Sucursal>().HasData(
            new Sucursal { Id=1, Nombre = "Sucursal Principal", Direccion = "123 Calle Principal" },
            new Sucursal { Id=2, Nombre = "Sucursal Central", Direccion = "456 Calle Central" },
            new Sucursal { Id=3, Nombre = "Sucursal Norte", Direccion = "789 Calle Norte" }
        );
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id=1, Nombre = "Aperitivos", SucursalId = 1 },
            new Categoria { Id=2, Nombre = "Plato Principal", SucursalId = 1 },
            new Categoria { Id=3, Nombre = "Postres", SucursalId = 2 },
            new Categoria { Id=4, Nombre = "Bebidas", SucursalId = 2 },
            new Categoria { Id=5, Nombre = "Especialidades", SucursalId = 3 }
        );
        modelBuilder.Entity<Producto>().HasData(
            new Producto {Id = 1, Nombre = "Rollitos Primavera", Precio = 4.99, CategoriaId = 1},
            new Producto {Id = 2, Nombre = "Tacos al Pastor", Precio = 9.99, CategoriaId = 2},
            new Producto {Id = 3, Nombre = "Pizza Margarita", Precio = 12.50, CategoriaId = 3},
            new Producto {Id = 4, Nombre = "Sushi de Salmón", Precio = 14.75, CategoriaId = 4},
            new Producto {Id = 5, Nombre = "Ensalada César", Precio = 7.99, CategoriaId = 1},
            new Producto {Id = 6, Nombre = "Hamburguesa Clásica", Precio = 8.50, CategoriaId = 2},
            new Producto {Id = 7, Nombre = "Pasta Carbonara", Precio = 10.25, CategoriaId = 3},
            new Producto {Id = 8, Nombre = "Paella Valenciana", Precio = 15.50, CategoriaId = 4},
            new Producto {Id = 9, Nombre = "Churrasco a la Parrilla", Precio = 18.00, CategoriaId = 5},
            new Producto {Id = 10, Nombre = "Empanadas de Carne", Precio = 3.75, CategoriaId = 1},
            new Producto {Id = 11, Nombre = "Crepes de Nutella", Precio = 5.00, CategoriaId = 2}
        );
    }
}