using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaImobiliario.Models;



namespace SistemaImobiliario.Data.Context
{
    public class DataContext : DbContext
    {


        public DbSet<Comprador> Compradores { get; set; }
        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
         public DataContext(DbContextOptions<DataContext> options) 
         : base(options){ }
        
        //public DataContext()
        private static IConfigurationRoot Configuration;
        public DataContext()
        {
            /*var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            Configuration = builder.Build();*/
        }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = (Configuration.GetConnectionString("StoreDB"));
            optionsBuilder.UseSqlServer(connection);
        }*/
       
        //public DbSet<CorretorComprador> CorretorCompradores { get; set; }      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         // ID de Comprador e Corretor para Tabela NxN entre as classes
         // Para injeção de dependencias
            modelBuilder.Entity<CorretorComprador>().HasKey(md => new { md.CompradorId,  md.CorretorId});

            modelBuilder.Entity<CorretorComprador>()
                .HasOne(cr => cr.Corretor)
                .WithMany(cp => cp.CorretorCompradores)
                .OnDelete(DeleteBehavior.Restrict);
        }

       
    }
}