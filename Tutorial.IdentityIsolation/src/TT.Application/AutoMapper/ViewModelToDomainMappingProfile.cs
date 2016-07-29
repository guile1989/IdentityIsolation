using AutoMapper;
using TT.Application.ViewModels;
using TT.Domain.Entities;

namespace TT.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<RegistrarClienteViewModel, Cliente>();

            CreateMap<RegistrarClienteViewModel, Endereco >();
        }
    }
}
