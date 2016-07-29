using System;

namespace TT.Domain.Entities
{
    public class Cliente
    {
        public Cliente()
        {
            
        }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public virtual Endereco Enderecos { get; set; }
    }
}
