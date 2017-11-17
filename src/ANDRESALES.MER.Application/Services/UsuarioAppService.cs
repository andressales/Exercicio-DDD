using ANDRESALES.MER.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ANDRESALES.MER.Application.ViewModels;
using ANDRESALES.MER.Infra.Data.UoW;
using ANDRESALES.MER.Domain.Interfaces;
using AutoMapper;
using ANDRESALES.MER.Domain.Models;

namespace ANDRESALES.MER.Application.Services
{
    public class UsuarioAppService : ServiceAppBase, IUsuarioAppService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILocalRepository _localRepository;
        private readonly IUsuarioPerfilRepository _usuarioPerfilRepository;

        public UsuarioAppService(IUsuarioRepository usuarioRepository,
            ILocalRepository localRepository,
            IUsuarioPerfilRepository usuarioPerfilRepository,
            IUnitOfWork uow)
            : base(uow)     
        {
            _usuarioRepository = usuarioRepository;
            _localRepository = localRepository;
            _usuarioPerfilRepository = usuarioPerfilRepository;
        }

        public UsuarioViewModel ObterPorId(Guid _id)
        {
            return Mapper.Map<UsuarioViewModel>(_usuarioRepository.ObterPorId(_id));
        }

        public UsuarioViewModel ObterPorCPF(string _cpf)
        {
            return Mapper.Map<UsuarioViewModel>(_usuarioRepository.Buscar(x => x.CPF == _cpf));
        }

        public ICollection<UsuarioViewModel> ObterTodos()
        {
            return Mapper.Map<ICollection<UsuarioViewModel>>(_usuarioRepository.ObterTodos());
        }

        public ICollection<LocalViewModel> ListarLocais(Guid _idUsuario)
        {
            return Mapper.Map<ICollection<LocalViewModel>>(_usuarioRepository.ObterPorId(_idUsuario).ListaLocal);
        }

        public ICollection<PerfilViewModel> ListarPerfis(Guid _idUsuario)
        {
            return Mapper.Map<ICollection<PerfilViewModel>>(_usuarioRepository.ObterPorId(_idUsuario).ListaPerfil);
        }

        public UsuarioViewModel Adicionar(UsuarioViewModel usuario)
        {
            return Mapper.Map<UsuarioViewModel>(_usuarioRepository.Adicionar(Mapper.Map<Usuario>(usuario)));
        }

        public UsuarioViewModel Atualizar(UsuarioViewModel usuario)
        {
            return Mapper.Map<UsuarioViewModel>(_usuarioRepository.Atualizar(Mapper.Map<Usuario>(usuario)));
        }

        public void Remover(Guid _id)
        {
            _usuarioRepository.Remover(_id);
        }

        public ICollection<LocalViewModel> AdicionarLocal(Guid IdUsuario, Guid IdLocal)
        {
            throw new NotImplementedException();
        }

        public ICollection<PerfilViewModel> AdicionarPerfil(Guid IdUsuario, Guid IdPerfil)
        {
            _usuarioPerfilRepository.Adicionar();
        }

        public void RemoverLocal(Guid _idUsuario, Guid _idPerfil)
        {
            _usuarioPerfilRepository.Remover(_idUsuario, _idPerfil);
        }

        public ICollection<PerfilViewModel> RemoverPerfil(Guid IdUsuario, Guid IdPerfil)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
