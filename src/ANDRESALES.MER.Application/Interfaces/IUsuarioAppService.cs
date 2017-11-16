using ANDRESALES.MER.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        UsuarioViewModel Adicionar(UsuarioViewModel usuario);
        UsuarioViewModel ObterPorId(Guid _id);
        UsuarioViewModel ObterPorCPF(string _cpf);
        UsuarioViewModel Atualizar(UsuarioViewModel usuario);
        void Remover(Guid _id);
        ICollection<UsuarioViewModel> ObterTodos();

        ICollection<PerfilViewModel> ListarPerfis(Guid IdUsuario);
        ICollection<PerfilViewModel> AdicionarPerfil(Guid IdUsuario, Guid IdPerfil);
        ICollection<PerfilViewModel> RemoverPerfil(Guid IdUsuario, Guid IdPerfil);

        ICollection<LocalViewModel> ListarLocais(Guid IdUsuario);
        ICollection<LocalViewModel> AdicionarLocal(Guid IdUsuario, Guid IdLocal);
        ICollection<LocalViewModel> RemoverLocal(Guid IdUsuario, Guid IdLocal);
    }
}
