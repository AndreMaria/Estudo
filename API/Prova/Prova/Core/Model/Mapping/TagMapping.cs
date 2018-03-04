using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prova.Core.Model.Mapping
{
    public class TagMapping: EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Common).HasMaxLength(500);
            this.Property(e => e.Normalized).HasMaxLength(500);
            this.HasRequired(x => x.Content).WithMany(x => x.Tags).HasForeignKey(y => y.IdContent);
        }
    }
}