﻿// <auto-generated />
using DropDownsAnidadosMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DropDownsAnidadosMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241029193322_MigraconInicial")]
    partial class MigraconInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucursalId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SucursalId");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Aperitivos",
                            SucursalId = 1
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Plato Principal",
                            SucursalId = 1
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Postres",
                            SucursalId = 2
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Bebidas",
                            SucursalId = 2
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Especialidades",
                            SucursalId = 3
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Nombre = "Rollitos Primavera",
                            Precio = 4.9900000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 2,
                            Nombre = "Tacos al Pastor",
                            Precio = 9.9900000000000002
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 3,
                            Nombre = "Pizza Margarita",
                            Precio = 12.5
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 4,
                            Nombre = "Sushi de Salmón",
                            Precio = 14.75
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 1,
                            Nombre = "Ensalada César",
                            Precio = 7.9900000000000002
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Nombre = "Hamburguesa Clásica",
                            Precio = 8.5
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 3,
                            Nombre = "Pasta Carbonara",
                            Precio = 10.25
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 4,
                            Nombre = "Paella Valenciana",
                            Precio = 15.5
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 5,
                            Nombre = "Churrasco a la Parrilla",
                            Precio = 18.0
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 1,
                            Nombre = "Empanadas de Carne",
                            Precio = 3.75
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 2,
                            Nombre = "Crepes de Nutella",
                            Precio = 5.0
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Sucursal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sucursal");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "123 Calle Principal",
                            Nombre = "Sucursal Principal"
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "456 Calle Central",
                            Nombre = "Sucursal Central"
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "789 Calle Norte",
                            Nombre = "Sucursal Norte"
                        });
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.HasOne("DropDownsAnidadosMVC.Models.Sucursal", "Sucursal")
                        .WithMany("Categorias")
                        .HasForeignKey("SucursalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sucursal");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Producto", b =>
                {
                    b.HasOne("DropDownsAnidadosMVC.Models.Categoria", "Categoria")
                        .WithMany("Productos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Categoria", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("DropDownsAnidadosMVC.Models.Sucursal", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
