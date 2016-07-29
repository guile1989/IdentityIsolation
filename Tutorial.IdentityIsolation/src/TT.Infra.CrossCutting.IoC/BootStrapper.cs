using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleInjector;
using TT.Application;
using TT.Domain.Interfaces;
using TT.Domain.Services;
using TT.Infra.CrossCutting.Identity.Configuration;
using TT.Infra.CrossCutting.Identity.Context;
using TT.Infra.CrossCutting.Identity.Model;
using TT.Infra.Data.Context;
using TT.Infra.Data.Interface;
using TT.Infra.Data.Repository;
using TT.Infra.Data.UoW;

namespace TT.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.RegisterPerWebRequest<ApplicationDbContext>();
            container.RegisterPerWebRequest<IUserStore<ApplicationUser>>(() => new UserStore<ApplicationUser>(new ApplicationDbContext()));
            container.RegisterPerWebRequest<IRoleStore<IdentityRole, string>>(() => new RoleStore<IdentityRole>());
            container.RegisterPerWebRequest<ApplicationRoleManager>();
            container.RegisterPerWebRequest<ApplicationUserManager>();
            container.RegisterPerWebRequest<ApplicationSignInManager>();

            //App 
            container.RegisterPerWebRequest<IClienteAppService, ClienteAppService>();

            // Domain
            container.RegisterPerWebRequest<IClienteService, ClienteService>();

            // Infra Dados
            container.RegisterPerWebRequest<IClienteRepository, ClienteRepository>();
            container.RegisterPerWebRequest<IEnderecoRepository, EnderecoRepository>();
            container.RegisterPerWebRequest<IUnitOfWork, UnitOfWork>();

            container.RegisterPerWebRequest<TutorialContext>();

        }
    }
}
