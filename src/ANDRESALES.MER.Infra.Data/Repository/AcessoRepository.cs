using ANDRESALES.MER.Domain.Interfaces;
using ANDRESALES.MER.Domain.Models;
using ANDRESALES.MER.Infra.Data.Context;

namespace ANDRESALES.MER.Infra.Data.Repository
{
    public class AcessoRepository : Repository<Acesso>, IAcessoRepository
    {
        public AcessoRepository(MERContext context) 
            : base(context)
        {
        }
    }
}