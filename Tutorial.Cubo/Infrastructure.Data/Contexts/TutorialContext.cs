using System;
using System.Data.Entity;
using Domain.Cadastro.Entities;
using Domain.Cadastro.Contracts.Contexts;
using System.Configuration;


namespace Infrastructure.Data.Contexts
{
    public class TutorialContext:DbContext, IDbContext
    {
        public TutorialContext():base(System.Configuration.ConfigurationSettings.AppSettings["ConnectionStringName"])
        {
        }

        public static object ConfigurationManager { get; private set; }

        #region [datasets]
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Properties<String>().Configure(c => c.IsUnicode(false));
            //modelBuilder.Configurations.Add<Usuario>(new Cadastro.Mappings.UsuarioMap());
            modelBuilder.Configurations.AddFromAssembly(typeof(TutorialContext).Assembly);
        }
    }
}
