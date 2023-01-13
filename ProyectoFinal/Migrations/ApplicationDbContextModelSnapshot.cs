﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoFinal.Context;

#nullable disable

namespace ProyectoFinal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProyectoFinal.Modelo.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("CleinteDireccion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ClienteCorreo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClienteNombre")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ClienteTelefono")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Condicion", b =>
                {
                    b.Property<int>("CondicionId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CondicionId"));

                    b.Property<string>("CondicionDesc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CondicionId");

                    b.ToTable("Condiciones");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.FormaPago", b =>
                {
                    b.Property<int>("FormaPagoId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FormaPagoId"));

                    b.Property<string>("FormaPagoDesc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("FormaPagoId");

                    b.ToTable("FormasPagos");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Inmueble", b =>
                {
                    b.Property<int>("InmuebleId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InmuebleId"));

                    b.Property<int>("InmuebleCosto")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<string>("InmuebleDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("InmuebleUbic")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("TipoInmuebleId")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.HasKey("InmuebleId");

                    b.HasIndex("TipoInmuebleId");

                    b.ToTable("Inmuebles");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.TipoInmueble", b =>
                {
                    b.Property<int>("TipoInmuebleId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TipoInmuebleId"));

                    b.Property<string>("TipoInmuebleDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("TipoInmuebleId");

                    b.ToTable("TiposInmuebles");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VentaId"));

                    b.Property<int?>("ClienteId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int?>("CondicionId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int?>("FormaPagoId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int?>("InmuebleId")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("VentaDesc")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("VentaFecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("VentaTotal")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<int>("VentaTotalGeneral")
                        .HasMaxLength(12)
                        .HasColumnType("int");

                    b.Property<int>("VentaTotalIva")
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    b.HasKey("VentaId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("CondicionId");

                    b.HasIndex("FormaPagoId");

                    b.HasIndex("InmuebleId")
                        .IsUnique();

                    b.ToTable("Ventas");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Inmueble", b =>
                {
                    b.HasOne("ProyectoFinal.Modelo.TipoInmueble", "Tipo")
                        .WithMany("Inmueble")
                        .HasForeignKey("TipoInmuebleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Venta", b =>
                {
                    b.HasOne("ProyectoFinal.Modelo.Cliente", "Cliente")
                        .WithMany("Ventas")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoFinal.Modelo.Condicion", "Condicion")
                        .WithMany("Ventas")
                        .HasForeignKey("CondicionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoFinal.Modelo.FormaPago", "FormaPago")
                        .WithMany("Ventas")
                        .HasForeignKey("FormaPagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProyectoFinal.Modelo.Inmueble", "Inmueble")
                        .WithOne("Ventas")
                        .HasForeignKey("ProyectoFinal.Modelo.Venta", "InmuebleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Condicion");

                    b.Navigation("FormaPago");

                    b.Navigation("Inmueble");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Cliente", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Condicion", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.FormaPago", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.Inmueble", b =>
                {
                    b.Navigation("Ventas");
                });

            modelBuilder.Entity("ProyectoFinal.Modelo.TipoInmueble", b =>
                {
                    b.Navigation("Inmueble");
                });
#pragma warning restore 612, 618
        }
    }
}
