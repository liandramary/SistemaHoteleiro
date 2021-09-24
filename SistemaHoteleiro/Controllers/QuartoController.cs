using System;
using System.Collections.Generic;
using System.Linq;
using SistemaHoteleiro.Data;
using SistemaHoteleiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace SistemaHoteleiro.Controllers
{
    [ApiController]
    [Route("hotel/quarto")]
    public class QuartoController : ControllerBase
    {
        private readonly DataContext _context;
        public QuartoController(DataContext context)
        {
            _context = context;
        }

        //POST: /hotel/quarto/create
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] Quarto quarto)
        {
            _context.Quartos.Add(quarto);
            _context.SaveChanges();
            return Created("", quarto);
        }

        //GET: /hotel/quarto/list
        [Route("list")]
        [HttpGet]
        public IActionResult List() => Ok(_context.Quartos.ToList());

        //GET: hotel/quarto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            //Buscar um objeto pela chave primária
            Quarto quarto = _context.Quartos.Find(id);
            if (quarto == null)
            {
                return NotFound();
            }
            return Ok(quarto);
        }

        //GET: hotel/quarto/delete/
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Quarto quarto = _context.Quartos.Find(id);
            if (quarto == null)
            {
                return NotFound();
            }
            _context.Quartos.Remove(quarto);
            _context.SaveChanges();
            return Ok(_context.Quartos.ToList());
        }

        //PUT: hotel/quarto/create
        [Route("update")]
        [HttpPut]
        public IActionResult Update([FromBody] Quarto quarto)
        {
            _context.Quartos.Update(quarto);
            _context.SaveChanges();
            return Ok(quarto);
        }
    }
}