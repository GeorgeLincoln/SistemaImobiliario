using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaImobiliario.Models
{
    public class Corretor
    {
        public Corretor()
        {
            CorretorCompradores = new List<CorretorComprador>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<CorretorComprador> CorretorCompradores { get; set; }

    }
}