using System;
using System.Collections.Generic;
using System.Linq;
using SistemaHoteleiro.Data;
using SistemaHoteleiro.Models;
using Microsoft.AspNetCore.Mvc;

namespace SistemaHoteleiro.Controllers
{
    [ApiController]
    [Route("hotel/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        //POST: /hotel/produto/create
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Created("", produto);
        }

        //GET: /hotel/produto/list
        [Route("list")]
        [HttpGet]
        public IActionResult List() => Ok(_context.Produtos.ToList());

        //GET: hotel/produto/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            //Buscar um objeto pela chave primária
            Produto produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        //GET: hotel/produto/delete/Bolacha
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete(string name)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Nome == name);
            if (produto == null)
            {
                return NotFound();
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok(_context.Produtos.ToList());
        }

        //PUT: /hotel/produto/create
        [Route("update")]
        [HttpPut]
        public IActionResult Update([FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }
}