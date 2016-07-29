using System;
using TT.Application.ViewModels;

namespace TT.Application
{
    public interface IClienteAppService : IDisposable
    {
        RegistrarClienteViewModel Adicionar(RegistrarClienteViewModel registrarClienteViewModel);


    }
}