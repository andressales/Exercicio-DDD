using AutoMapper;

namespace ANDRESALES.MER.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistersMapping()
        {
            Mapper.Initialize(mapper => {
                mapper.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}
