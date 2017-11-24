using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Cadastro.Contracts.Repositories;
using Infrastructure.Data.Cadastro.Repositories;
using Microsoft.Practices.Unity;

namespace Startup.Repositories
{
    public static class CadastroRepositoryDependencyResolver
    {
        public static void RegisterDependencies(UnityContainer container) {
            container.RegisterType<IUsuarioRepository, UsuarioRepository>(new HierarchicalLifetimeManager());
        }
    }
}
