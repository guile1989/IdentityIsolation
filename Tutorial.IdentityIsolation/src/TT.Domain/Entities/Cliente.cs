using System;

namespace TT.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Endereco Enderecos { get; set; }
        public virtual Usuario Usuarios { get; set; }
    }
}
