using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Domain.Cadastro.Contracts.Contexts;
using Infrastructure.Data.Contexts;

namespace Startup.Data
{
    public static class ContextDependencyResolver
    {
        public static void RegisterDependencies(UnityContainer container)
        {
            container.RegisterType<IDbContext, TutorialContext>(new HierarchicalLifetimeManager());
        }
    }
}
