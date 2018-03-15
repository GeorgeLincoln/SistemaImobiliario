namespace SistemaImobiliario.Models
{
    public class CorretorComprador
    {
        public long  IdCorretorComprador  { get; set; }
        
        public long  IdCorretor  { get; set; }
        public Corretor Corretor { get; set; }

        public long  IdComprador  { get; set; }
        public Comprador  Comprador  { get; set; }
    }
}