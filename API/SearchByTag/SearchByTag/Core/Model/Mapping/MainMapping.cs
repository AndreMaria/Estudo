using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace SearchByTag.Core.Model.Mapping
{
    public class MainMapping: EntityTypeConfiguration<Main>
    {
        public MainMapping()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Text).HasMaxLength(500);
        }
    }
}