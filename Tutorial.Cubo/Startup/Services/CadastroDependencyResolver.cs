using Domain.Cadastro.Contracts.Services;
using Infrastructure.Data.Cadastro.Repositories;
using AppService.Cadastro;
using Microsoft.Practices.Unity;

namespace Startup.Services
{
    public static class CadastroDependencyResolver
    {
        public static void RegisterDependencies(UnityContainer container)
        {
            container.RegisterType<IUsuarioAppService,UsuarioAppService>(new HierarchicalLifetimeManager());
        }
    }
}
