﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SistemaImobiliario.Data.Context;
using System;

namespace SistemaImobiliario.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaImobiliario.Models.Comprador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Compradores");
                });

            modelBuilder.Entity("SistemaImobiliario.Models.Corretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmpresaId");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("Corretores");
                });

            modelBuilder.Entity("SistemaImobiliario.Models.CorretorComprador", b =>
                {
                    b.Property<int>("CompradorId");

                    b.Property<int>("CorretorId");

                    b.Property<int>("Id");

                    b.HasKey("CompradorId", "CorretorId");

                    b.HasIndex("CorretorId");

                    b.ToTable("CorretorComprador");
                });

            modelBuilder.Entity("SistemaImobiliario.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EnderecoEmpresa");

                    b.Property<string>("NomeEmpresa");

                    b.Property<string>("TelefoneEmpresa");

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("SistemaImobiliario.Models.Imovel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("EmpresaImovelId");

                    b.Property<string>("EnderecoImovel");

                    b.Property<string>("NomeImovel");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaImovelId");

                    b.ToTable("Imoveis");
                });

            modelBuilder.Entity("SistemaImobiliario.Models.Corretor", b =>
                {
                    b.HasOne("SistemaImobiliario.Models.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId");
                });

            modelBuilder.Entity("SistemaImobiliario.Models.CorretorComprador", b =>
                {
                    b.HasOne("SistemaImobiliario.Models.Comprador", "Comprador")
                        .WithMany("CorretorCompradores")
                        .HasForeignKey("CompradorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SistemaImobiliario.Models.Corretor", "Corretor")
                        .WithMany("CorretorCompradores")
                        .HasForeignKey("CorretorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("SistemaImobiliario.Models.Imovel", b =>
                {
                    b.HasOne("SistemaImobiliario.Models.Empresa", "EmpresaImovel")
                        .WithMany()
                        .HasForeignKey("EmpresaImovelId");
                });
#pragma warning restore 612, 618
        }
    }
}
