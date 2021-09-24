using SistemaHoteleiro.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaHoteleiro.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        //Lista de propriedades das classes de modelo que vão virar tabelas no banco
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}