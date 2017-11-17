using System;
using ANDRESALES.MER.Domain.Interfaces;
using ANDRESALES.MER.Domain.Models;
using ANDRESALES.MER.Infra.Data.Context;
using System.Collections.Generic;

namespace ANDRESALES.MER.Infra.Data.Repository
{
    public class UsuarioPerfilRepository : Repository<UsuarioPerfil>, IUsuarioPerfilRepository
    {
        private readonly IPerfilRepository _perfilRepository;
        public UsuarioPerfilRepository(MERContext context) 
            : base(context)
        {
        }

        public void Remover(Guid _idUsuario, Guid _idPerfil)
        {
            var usuarioPerfil = new UsuarioPerfil() { IdUsuario = _idUsuario, IdPerfil = _idPerfil };
            _dbSet.Remove(usuarioPerfil);
        }

        public override UsuarioPerfil Adicionar(UsuarioPerfil entity)
        {
            throw new InvalidOperationException("Método não habilitado, utilize o método: public ICollection<UsuarioPerfil> Adicionar(Guid _idUsuario, Guid _idPerfil)");
        }

        public ICollection<UsuarioPerfil> Adicionar(Guid _idUsuario, Guid _idPerfil)
        {
            var usuarioPerfil = new UsuarioPerfil
            {
                IdUsuario = _idUsuario,
                IdPerfil = _idPerfil,
                DataCriacao = DateTime.Now
            };
            throw new Exception();
            //Adicionar(usuarioPerfil);
            _dbSet.Add(usuarioPerfil);
        }
    }
}