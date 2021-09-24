using System;

namespace SistemaHoteleiro.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
    }
}