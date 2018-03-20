using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SistemaImobiliario.Models;
using SistemaImobiliario.Repositories;

namespace SistemaImobiliario.Controllers
{
    public class ImovelController : ControllerBase<Imovel>
    {
        public ImovelController(RepositoryBase<Imovel> repository) : base(repository)
        {
        }
    }
}
