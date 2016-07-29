using AutoMapper;
using TT.Application.ViewModels;
using TT.Domain.Entities;

namespace TT.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Cliente, RegistrarClienteViewModel>();

            CreateMap<Endereco, RegistrarClienteViewModel>();

        }
    }
}
