using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace TagAlize.Core.Model.Mapping
{
    public class SubjectMatterMapping : EntityTypeConfiguration<SubjectMatter>
    {
        public SubjectMatterMapping()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Content).HasMaxLength(2500);
        }
    }
}