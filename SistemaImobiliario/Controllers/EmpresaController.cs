using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaImobiliario.Models;
using SistemaImobiliario.Repositories;

namespace SistemaImobiliario.Controllers
{
    public class EmpresaController : ControllerBase<Empresa>
    {
        public EmpresaController(RepositoryBase<Empresa> repository) : base(repository)
        {
        }
    }
}
