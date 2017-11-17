using ANDRESALES.MER.Domain.Models;
using System;

namespace ANDRESALES.MER.Domain.Interfaces
{
    public interface IUsuarioPerfilRepository : IRepository<UsuarioPerfil>
    {
        void Remover(Guid _idUsuario, Guid _idPerfil);
    }
}