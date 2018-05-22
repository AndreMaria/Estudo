using System.Data.Entity.ModelConfiguration;

namespace TutorialAPIEntity.Core.Model.Mapping
{
    public class TagsMapping : EntityTypeConfiguration<Tags>
    {
        public TagsMapping() {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(e => e.Normalized).HasMaxLength(500);
            this.Property(e => e.SimpleText).HasMaxLength(500);
            this.HasRequired(e => e.SubjectMatter).WithMany(x => x.Tags).HasForeignKey(y => y.IdSubjectMatter);
        }
    }
}