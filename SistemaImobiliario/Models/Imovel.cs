using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaImobiliario.Models
{
    public class Imovel
    {
        public int Id  { get; set; }
        public string NomeImovel { get; set; }
        public Empresa EmpresaImovel { get; set; }
        public string EnderecoImovel { get; set; }

    }

}