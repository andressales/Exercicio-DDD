using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Infra.Data.UoW
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
