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
        }
    }
}