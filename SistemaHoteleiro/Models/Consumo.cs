using  System;

namespace SistemaHoteleiro.Models
{

    public class Consumo
    {
        public Consumo() => CriadoEm = DateTime.Now;

        public int Id { get; set; }
        public Reserva Reserva { get; set; }
        public int codConsumo { get; set; }
        public Produto Produto { get; set; }
        public DateTime CriadoEm { get; set; }
        public float ValorTotal { get; set; }

        public override string ToString() =>
         $" CodReserva: {Reserva} | Produto: {Produto} | Preço: {ValorTotal:C2} | Data do Consumo: {CriadoEm}";

    }

}