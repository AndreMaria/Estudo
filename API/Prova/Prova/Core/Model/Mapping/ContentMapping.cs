using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Prova.Core.Model.Mapping
{
    public class ContentMapping : EntityTypeConfiguration<Content>
    {
        public ContentMapping()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(e => e.Text).HasMaxLength(500);
        }
    }
}