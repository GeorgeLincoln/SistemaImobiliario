using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaImobiliario.Models;


namespace SistemaImobiliario.Models
{
    public class Comprador
    {
        public Comprador()
        {
            CorretorCompradores = new List<CorretorComprador>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<CorretorComprador> CorretorCompradores { get; set; }
    }
}