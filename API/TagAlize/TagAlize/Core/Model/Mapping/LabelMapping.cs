using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace TagAlize.Core.Model.Mapping
{
    public class LabelMapping : EntityTypeConfiguration<Label>
    {
        public LabelMapping()
        {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(e => e.Title).HasMaxLength(500);

            this.HasRequired(e => e.SubjectMatter).WithMany(x => x.Labels).HasForeignKey(y => y.IdSubjectMatter);
        }
    }
}