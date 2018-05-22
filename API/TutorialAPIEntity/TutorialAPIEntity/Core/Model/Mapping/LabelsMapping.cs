using System.Data.Entity.ModelConfiguration;

namespace TutorialAPIEntity.Core.Model.Mapping
{
    public class LabelsMapping: EntityTypeConfiguration<Labels>
    {
        public LabelsMapping() {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.Title).HasMaxLength(500);
            this.HasRequired(e => e.SubjectMatter).WithMany(x => x.Labels).HasForeignKey(y => y.IdSubjectMatter);
        }
    }
}