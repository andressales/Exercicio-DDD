using ANDRESALES.MER.Domain.Interfaces;
using ANDRESALES.MER.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANDRESALES.MER.Infra.Data.Context;

namespace ANDRESALES.MER.Infra.Data.Repository
{
    public class PerfilRepository : Repository<Perfil>, IPerfilRepository
    {
        public PerfilRepository(MERContext context) 
            : base(context)
        {
        }
    }
}