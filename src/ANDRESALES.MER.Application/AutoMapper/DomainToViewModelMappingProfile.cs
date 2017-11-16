using ANDRESALES.MER.Application.ViewModels;
using ANDRESALES.MER.Domain.Models;
using AutoMapper;

namespace ANDRESALES.MER.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
            CreateMap<Usuario, PerfilViewModel>().ReverseMap();
            CreateMap<Usuario, LocalViewModel>().ReverseMap();

            CreateMap<Local, LocalViewModel>().ReverseMap();
            CreateMap<Local, UsuarioViewModel>().ReverseMap();

            CreateMap<Acesso, AcessoViewModel>().ReverseMap();
            CreateMap<Acesso, PerfilViewModel>().ReverseMap();

            CreateMap<Perfil, PerfilViewModel>().ReverseMap();
            CreateMap<Perfil, UsuarioViewModel>().ReverseMap();
            CreateMap<Perfil, AcessoViewModel>().ReverseMap();
        }
    }
}