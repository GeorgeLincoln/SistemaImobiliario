using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaImobiliario.Data.Context;
using SistemaImobiliario.Models;
using SistemaImobiliario.Repositories;

namespace SistemaImobiliario.Controllers
{
    public class EmpresaController : ControllerBase<Empresa>
    {
        public EmpresaController(DataContext context) : base(context)
        {
        }
    }
}
