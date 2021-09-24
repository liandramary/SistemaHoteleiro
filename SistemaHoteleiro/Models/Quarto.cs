using  System ;

namespace SistemaHoteleiro.Models
{
    public class Quarto
    {
        public int Id { get; set; }
        public string AndarQuarto { get; set; }
        public string TipoQuarto { get; set; }
        public float ValorDiaria { get; set; }
        public bool Disponivel { get; set; }
    }
}