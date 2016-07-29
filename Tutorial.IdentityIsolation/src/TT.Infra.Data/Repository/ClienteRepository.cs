using TT.Domain.Entities;
using TT.Domain.Interfaces;
using TT.Infra.Data.Context;

namespace TT.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(TutorialContext context) : base(context)
        {
        }
    }
}
