using Infrastructure.Data.Contexts;
using Microsoft.Practices.Unity;
using Startup.Data;
using Startup.Repositories;
using Startup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class UnityDependencyResolver
    {
        public static void RegisterDependencies(UnityContainer container)
        {
            ContextDependencyResolver.RegisterDependencies(container);

            RepositoryRegister(container);
            ServiceRegister(container);
        }

        private static void RepositoryRegister(UnityContainer container)
        {
            CadastroRepositoryDependencyResolver.RegisterDependencies(container);
        }

        private static void ServiceRegister(UnityContainer container)
        {
            CadastroDependencyResolver.RegisterDependencies(container);
        }
    }
}
