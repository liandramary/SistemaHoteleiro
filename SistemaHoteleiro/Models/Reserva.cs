using  System ;

namespace SistemaHoteleiro.Models
{
    public class Reserva
    {
        public Reserva() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Quarto Quarto { get; set; }
        public Consumo Consumo { get; set; }
        public DateTime DataCheckin { get; set; }
        public DateTime DataCheckout { get; set; }
        public double ValorTotal { get; set; }
        public DateTime CriadoEm { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
    }
}