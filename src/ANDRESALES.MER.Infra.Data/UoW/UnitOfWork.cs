using ANDRESALES.MER.Infra.Data.Context;

namespace ANDRESALES.MER.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MERContext _context;

        public UnitOfWork(MERContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
