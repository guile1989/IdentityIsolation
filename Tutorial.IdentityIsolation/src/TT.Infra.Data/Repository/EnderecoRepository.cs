using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Domain.Entities;
using TT.Domain.Interfaces;
using TT.Infra.Data.Context;

namespace TT.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(TutorialContext context) : base(context)
        {
        }
    }
}
