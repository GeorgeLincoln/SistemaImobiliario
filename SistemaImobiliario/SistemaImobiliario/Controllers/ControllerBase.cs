using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaImobiliario.Data.Context;
using SistemaImobiliario.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SistemaImobiliario.Models;

namespace SistemaImobiliario.Controllers
{
    [Route("api/[controller]/")]
    public abstract class ControllerBase<T> : Controller where T : class
    {
        private readonly DataContext _context;


        private readonly IRepositoryBase _repository;
        private RepositoryBase<T> repository;

        public ControllerBase(DataContext context)
        {
            this._context = context;
            repository = new RepositoryBase<T>(_context);
        }



        [HttpGet]
        public virtual IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }
        [HttpPost]
        public IActionResult Create([FromBody]T entity)
        {
            if (entity == null)
            {
                return BadRequest("Objeto não pode ser null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return Ok(entity);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] T entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            var exist = _context.Set<T>().Find(id);
            _context.Entry(exist).CurrentValues.SetValues(entity);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity == null)
            {
                return NotFound();
            }
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
            return Ok();
        }

        private interface IRepositoryBase
        {
        }
    }
}