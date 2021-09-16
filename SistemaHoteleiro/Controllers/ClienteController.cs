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

    //Post: /Hotel/cliente/cadastro
    [Route("cadastro")]
    [HttpPost]

    public IActionResult Create([FromBody] Cliente cliente)
    {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
            return Created("", cliente);
    }

    //Get: /Hotel/cliente/delete
    [Route("delete/{Cpf}")]
    [HttpDelete]

    public IActionResult Delete(int Cpf)
    {
        Cliente cliente = _context.Cliente  .FirstOrDefault (cliente => cliente.Cpf == Cpf);
        if (cliente == null)
        {
            return NotFound("O cliente não existe em nosso banco de dados. Verifique se preencheu os campos corretamente");

        }
        _context.Cliente.Remove(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }

    //Put: /Hotel/cliente/alterar
    [Route("alterar")]
    [HttpPut]

    public IActionResult Update([FromBody] Cliente cliente)
    {
        _context.Cliente.Update(cliente);
        _context.SaveChanges();
        return Ok(cliente);
    }

    //GET: /hotel/cliente/consulta
    //[Route("consulta")]
    //[HttpGet]
    //public IActionResult Read() => Ok(_context.Cliente.Read());


    //POST: /hotel/cliente/lista
    [Route("Lista")]
    [HttpGet]
    public IActionResult List() => Ok(_context.Cliente.ToList());
  }
}