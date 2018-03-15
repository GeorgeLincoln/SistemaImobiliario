using Microsoft.EntityFrameworkCore;
using SistemaImobiliario.Models;



namespace SistemaImobiliario.Data.Context
{
    public class DataContext : DbContext
    {
         public DataContext(DbContextOptions<DataContext> options) 
         : base(options){ }
        public DataContext()
        {}
        public DbSet<Comprador> Compradores { get; set; }
        public DbSet<Corretor> Corretores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }
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
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=SistemaImobiliario;Trusted_Connection=True;");
        }

    }
}