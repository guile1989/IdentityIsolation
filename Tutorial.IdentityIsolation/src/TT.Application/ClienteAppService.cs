using System;
using AutoMapper;
using TT.Application.ViewModels;
using TT.Domain.Entities;
using TT.Domain.Interfaces;
using TT.Infra.CrossCutting.Identity.Model;
using TT.Infra.Data.Interface;
using Microsoft.AspNet.Identity;
using TT.Infra.CrossCutting.Identity.Configuration;

namespace TT.Application
{
    public class ClienteAppService : ApplicationService, IClienteAppService

    {
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        private readonly IClienteService _clienteService;

        public ClienteAppService(IUnitOfWork uow, ApplicationSignInManager signInManager, ApplicationUserManager userManager, IClienteService clienteService) : base(uow)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _clienteService = clienteService;
        }

        public RegistrarClienteViewModel Adicionar(RegistrarClienteViewModel registrarClienteViewModel)
        {
            var cliente = Mapper.Map<RegistrarClienteViewModel, Cliente>(registrarClienteViewModel);
            var endereco = Mapper.Map<RegistrarClienteViewModel, Endereco>(registrarClienteViewModel);

            cliente.Enderecos = endereco;
            cliente.DataCadastro = DateTime.Now;
            var clienteReturn = _clienteService.Adicionar(cliente);
    
            Commit();

            //Identity
            var user = new ApplicationUser { UserName = registrarClienteViewModel.Email, Email = registrarClienteViewModel.Email, Clientes = clienteReturn};
            registrarClienteViewModel.ApplicationUser = user;

            return registrarClienteViewModel;
        }

        public void Dispose()
        {
            _clienteService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
