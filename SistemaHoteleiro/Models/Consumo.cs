using  System;

namespace SistemaHoteleiro.Models
{

    public class Consumo
    {
        public Consumo() => CriadoEm = DateTime.Now;

        public int CodReserva { get; set; }

        public int codConsumo { get; set; }

        public string Produto { get; set; }

        public int Quantidade { get; set; }

        public DateTime CriadoEm { get; set; }

        public float ValorDiaria { get; set; }

        public override string ToString() =>
         $" CodReserva: {CodReserva} | Produto: {Produto} | Preço: {ValorDiaria:C2} | Data do Consumo: {CriadoEm}";


    }

}