using System.Linq;
using SistemaHoteleiro.Models;
using SistemaHoteleiro.Data;
using Microsoft.AspNetCore.Mvc;


namespace SistemaHoteleiro.Controllers
{
    [ApiController]
    [Route("hotel/consumo")]

    public class ConsumoController : ControllerBase
    {
        private readonly DataContext _context;

        public ConsumoController(DataContext context)
        {
            _context = context;
        }

    //Post: /Hotel/consumo/create
    [Route("create")]
    [HttpPost]
    public IActionResult Create([FromBody] Consumo consumo)
    {
            _context.Consumos.Add(consumo);
            _context.SaveChanges();
            return Created("", consumo);
    }

    //Post: /Hotel/consumo/list
    [Route("list")]
    [HttpGet]
    public IActionResult List() => Ok(_context.Consumos.ToList());

    }
}