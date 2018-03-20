using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaImobiliario.Data.Context;
using SistemaImobiliario.Models;
using SistemaImobiliario.Repositories;

namespace SistemaImobiliario.Controllers
{
    public class CompradorController : ControllerBase<Comprador>
    {
        public CompradorController(RepositoryBase<Comprador> repository) : base(repository)
        {
        }
    }

}
