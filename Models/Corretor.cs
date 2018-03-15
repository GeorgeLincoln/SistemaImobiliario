using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaImobiliario.Models
{


    public class Corretor
    {
        public long IdCorretor { get; set; }
        public string NomeCorretor { get; set; }
        public Empresa EmpresaCorretor { get; set; }
        public string TelefoneCorretor { get; set; }
    }


}
