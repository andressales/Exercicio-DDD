using ANDRESALES.MER.Domain.Models;

namespace ANDRESALES.MER.Domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>
    {
        Usuario BuscarPorCPF(string cpf);
    }
}
