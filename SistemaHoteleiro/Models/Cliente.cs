namespace SistemaHoteleiro.Models
{
    public class Cliente
    {
        public Cliente() => CriadoEm = DateTime.Now;

        public int IdCliente { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} \n CPF: {Cpf} \n E-mail: {Email} \n Criado em: {CriadoEm}";
    }
}