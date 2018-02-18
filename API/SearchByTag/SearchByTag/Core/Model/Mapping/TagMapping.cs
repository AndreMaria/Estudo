using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchByTag.Core.Model.Mapping
{
    public class TagMapping : EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Item).HasMaxLength(500);
            this.Property(e => e.Normalized).HasMaxLength(500);
            this.HasRequired(e => e.Main).WithMany(x => x.Tags).HasForeignKey(y => y.IdMain);
        }
    }
}