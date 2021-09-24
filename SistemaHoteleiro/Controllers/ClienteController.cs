using System.Linq;
using SistemaHoteleiro.Models;
using SistemaHoteleiro.Data;
using Microsoft.AspNetCore.Mvc;


namespace SistemaHoteleiro.Controllers
{
    [ApiController]
    [Route("hotel/cliente")]

    public class ClienteController : ControllerBase
    {
        private readonly DataContext _context;

        public ClienteController(DataContext context)
        {
            _context = context;
        }

    //Post: /Hotel/cliente/create
    [Route("create")]
    [HttpPost]
    public IActionResult Create([FromBody] Cliente cliente)
    {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return Created("", cliente);
    }

    //Get: /Hotel/cliente/delete
    [Route("delete/{name}")]
    [HttpDelete]
    public IActionResult Delete(string name)
    {
        Cliente cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Nome == name);
        if (cliente == null)
        {
            return NotFound("O cliente não existe em nosso banco de dados. Verifique se preencheu os campos corretamente");

        }
        _context.Clientes.Remove(cliente);
        _context.SaveChanges();
        return Ok(_context.Clientes.ToList());
    }

    //Put: /Hotel/cliente/update
    [Route("update")]
    [HttpPut]
    public IActionResult Update([FromBody] Cliente cliente)
    {
        _context.Clientes.Update(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }

    //GET: /hotel/cliente/getbyid/2
    [Route("getbyid/{id}")]
    [HttpGet]
    public IActionResult GetById([FromRoute] int id)
    {
        //Buscar um objeto pela chave primária
        Cliente cliente = _context.Clientes.Find(id);
        if (cliente == null)
        {
            return NotFound();
        }
        return Ok(cliente);
    }

    //POST: /hotel/cliente/list
    [Route("list")]
    [HttpGet]
    public IActionResult List() => Ok(_context.Clientes.ToList());
  }
}