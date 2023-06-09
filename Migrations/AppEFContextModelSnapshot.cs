﻿// <auto-generated />
using AppEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppEF.Migrations
{
    [DbContext(typeof(AppEFContext))]
    partial class AppEFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppEF.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente", (string)null);

                    b.HasData(
                        new
                        {
                            ClienteId = 1,
                            Email = "juan@gmail.com",
                            Nombre = "Juan",
                            Numero = "1234567890"
                        },
                        new
                        {
                            ClienteId = 2,
                            Email = "pedro@gmail.com",
                            Nombre = "Pedro",
                            Numero = "1234567890"
                        },
                        new
                        {
                            ClienteId = 3,
                            Email = "maria@gmail.com",
                            Nombre = "Maria",
                            Numero = "1234567890"
                        },
                        new
                        {
                            ClienteId = 4,
                            Email = "luis@gmail.com",
                            Nombre = "Luis",
                            Numero = "1234567890"
                        });
                });

            modelBuilder.Entity("AppEF.Models.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto", (string)null);

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Descripcion = "Descripcion 1",
                            Nombre = "Producto 1",
                            Precio = 100.0
                        },
                        new
                        {
                            ProductoId = 2,
                            Descripcion = "Descripcion 2",
                            Nombre = "Producto 2",
                            Precio = 200.0
                        },
                        new
                        {
                            ProductoId = 3,
                            Descripcion = "Descripcion 3",
                            Nombre = "Producto 3",
                            Precio = 300.0
                        },
                        new
                        {
                            ProductoId = 4,
                            Descripcion = "Descripcion 4",
                            Nombre = "Producto 4",
                            Precio = 400.0
                        },
                        new
                        {
                            ProductoId = 5,
                            Descripcion = "Descripcion 5",
                            Nombre = "Producto 5",
                            Precio = 500.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
