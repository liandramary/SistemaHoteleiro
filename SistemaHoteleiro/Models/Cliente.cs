<<<<<<< Updated upstream
using  System ;

namespace SistemaHoteleiro.Models
{
    public class Cliente
    {
        public Cliente() => CriadoEm = DateTime.Now;

        public int IdCliente { get; set; }
        public float Cpf { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} \n CPF: {Cpf} \n E-mail: {Email} \n Criado em: {CriadoEm}";
    }
=======
using System;

namespace Cliente.Models
{
        public class Cliente
        {
           public Cliente() => CriadoEm = DateTime.Now;

           public Nome string { get; set; }

           public Cpf int { get; set; }

           public Email string { get; set; }

           public DateTime CriadoEmail { get; set; }

           public override string ToString() {=>
            $"Nome: {Nome} | Criado em: {CriadoEm}";
        }
>>>>>>> Stashed changes
}