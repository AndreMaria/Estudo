using System.Data.Entity;
using ProvaApi.Core.Model;
using ProvaApi.Core.Model.Mapping;

namespace ProvaApi.Core.Repository
{
    public class TagAlizeContext: DbContext
    {
        public TagAlizeContext() : base("TagAlizeContext")
        {

        }

        public DbSet<SubjectMatter> SubjectMatter { get; set; }
        public DbSet<Label> Label { get; set; }
        public DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SubjectMatterMapping());
            modelBuilder.Configurations.Add(new LabelMapping());
            modelBuilder.Configurations.Add(new TagMapping());
        }
    }
}