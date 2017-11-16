using ANDRESALES.MER.Infra.Data.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Application.Services
{
    public class ServiceAppBase
    {
        private readonly IUnitOfWork _uow;

        public ServiceAppBase(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public void Commit()
        {
            _uow.Commit();
        }
    }
}
