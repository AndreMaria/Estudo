using System.Data.Entity;

namespace SearchByTag.Core.Repository
{
    public class SearchByTagContext: DbContext
    {
        public SearchByTagContext() : base("SearchByTagContext")
        {

        }

        DbSet<Model.Main> Main { get; set; }
        DbSet<Model.Label> Label { get; set; }
        DbSet<Model.Tag> Tag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new Model.Mapping.MainMapping());
            modelBuilder.Configurations.Add(new Model.Mapping.LabelMapping());
            modelBuilder.Configurations.Add(new Model.Mapping.TagMapping());
        }
    }
}