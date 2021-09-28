using System.Linq;
using SistemaHoteleiro.Models;
using SistemaHoteleiro.Data;
using Microsoft.AspNetCore.Mvc;


namespace SistemaHoteleiro.Controllers
{
    [ApiController]
    [Route("hotel/reserva")]

    public class ReservaController : ControllerBase
    {
        private readonly DataContext _context;

        public ReservaController(DataContext context)
        {
            _context = context;
        }

    //Post: /Hotel/reserva/create
    [Route("create")]
    [HttpPost]
    public IActionResult Create([FromBody] Reserva reserva)
    {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
            return Created("", reserva);
    }



    //Get: /Hotel/reserva/delete
    [Route("delete/{id}")]
    [HttpDelete]
    public IActionResult Delete(int id)
    {
        Reserva reserva = _context.Reservas.FirstOrDefault(reserva => reserva.Id == id);
        if (reserva == null)
        {
            return NotFound("O cliente não fez nenhuma reserva em nosso sistema. Verifique se preencheu os campos corretamente");

        }
        _context.Reservas.Remove(reserva);
        _context.SaveChanges();
        return Ok(_context.Reservas.ToList());
    }

    //Put: /Hotel/reserva/update
    [Route("update")]
    [HttpPut]
    public IActionResult Update([FromBody] Reserva reserva)
    {
        _context.Reservas.Update(reserva);
        _context.SaveChanges();
        return Ok(reserva);
    }


    //POST: /hotel/cliente/list
    [Route("list")]
    [HttpGet]
    public IActionResult List() => Ok(_context.Reservas.ToList());
  }

}