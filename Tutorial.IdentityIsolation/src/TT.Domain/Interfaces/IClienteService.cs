using System;
using System.Collections.Generic;
using TT.Domain.Entities;

namespace TT.Domain.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Cliente Adicionar(Cliente cliente);
        Cliente ObterPorId(int id);
        IEnumerable<Cliente> ObterTodos();
        Cliente Atualizar(Cliente cliente);
        void Remover(int id);

    }
}
