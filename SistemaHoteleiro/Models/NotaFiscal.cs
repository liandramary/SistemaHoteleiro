using System;

namespace SistemaHoteleiro.Models
{
    public class NotaFiscal
    {
        public float CodigoBarras { get; set; }
        public Cliente Cliente { get; set; }
        public float ValorTotal { get; set; }
    }
}