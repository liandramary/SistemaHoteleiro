<<<<<<< Updated upstream
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
=======
using System;
using Client.Models;
using Hotel.Data;

namespace Cliente.Controllers
{
    private readonly DataContext _context;

    public ClienteController(DataContext context)
    {
        _context = context;
    }


    //Post: /Hotel/cliente/cadastro
    [Route("cadastro")]
    [httpPost]

    public IActionResult Create([FromBody] Cliente cliente)
    {
        _context.Cliente.Add(cliente);
        _context.SaveChanges();
        return Created("Cliente cadastrado com sucesso", cliente);
    }

    //Get: /Hotel/cliente/delete
    [httpDelete]
    [Route("delete/{Cpf}")]

    public IActionResult Delete(int Cpf)
    {
        Cliente cliente = _context.Cliente.FirstOrDefault (cliente => cliente.Cpf == Cpf);
>>>>>>> Stashed changes
        if (cliente == null)
        {
            return NotFound("O cliente não existe em nosso banco de dados. Verifique se preencheu os campos corretamente");

        }
        _context.Cliente.Remove(cliente);
        _context.SaveChanges();
<<<<<<< Updated upstream
        return Ok(cliente);
    }

    //Put: /Hotel/cliente/alterar
    [Route("alterar")]
=======
        return (Cliente);
    }

    //Put: /Hotel/cliente/alterar
    [Route("update")]
>>>>>>> Stashed changes
    [HttpPut]

    public IActionResult Update([FromBody] Cliente cliente)
    {
        _context.Cliente.Update(cliente);
<<<<<<< Updated upstream
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
=======
        _content.SaveChanges();
        return Ok(cliente);
    }

    //Post: /Hotel/cliente/ConsultarDados
    public IActionResult ConsultarDados([FromBody] Cliente cliente)
    {
        return (cliente);
    }
>>>>>>> Stashed changes
}