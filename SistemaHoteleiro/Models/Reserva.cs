using  System ;

namespace SistemaHoteleiro.Models
{
    public class Reserva
    {
        public Reserva() => CriadoEm = DateTime.Now;

        public int CodReserva { get; set; }
        public int IdCliente { get; set; } //FK
        public int CodQuarto { get; set; } //FK
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public DateTime CriadoEm { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Quarto Quarto { get; set; }
    }
}