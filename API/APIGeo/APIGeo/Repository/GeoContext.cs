using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using APIGeo.Model;
using APIGeo.Model.Mapping;

namespace APIGeo.Repository
{
    public class GeoContext: DbContext
    {
        public static string ConnectionString { get; set; }

        public GeoContext() : base(ConnectionString)
        {

        }

        public virtual DbSet<Principal> Principals { get; set; }
        public virtual DbSet<Label> Labels { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new PrincipalMapping());
            modelBuilder.Configurations.Add(new LabelMapping());
            modelBuilder.Configurations.Add(new TagMapping());
        }
    }
}
