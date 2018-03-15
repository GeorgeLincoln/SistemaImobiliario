using SistemaImobiliario.Models;

namespace SistemaImobiliario.Models
{
    public class CorretorComprador
    {
        public int Id { get; set; }
        public int CorretorId { get; set; }
        public int CompradorId { get; set; }

        public virtual Comprador Comprador { get; set; }
        public virtual Corretor Corretor { get; set; }
    }
}