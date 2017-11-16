using ANDRESALES.MER.Domain.Interfaces;
using ANDRESALES.MER.Domain.Models;
using System.Linq;
using ANDRESALES.MER.Infra.Data.Context;

namespace ANDRESALES.MER.Infra.Data.Repository
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MERContext context) 
            : base(context)
        {
        }

        public Usuario BuscarPorCPF(string cpf)
        {
            return Buscar(x => x.CPF == cpf).FirstOrDefault();
        }
    }
}
