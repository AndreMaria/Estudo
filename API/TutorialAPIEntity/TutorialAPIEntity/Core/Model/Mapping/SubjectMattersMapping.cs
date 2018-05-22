using System.Data.Entity.ModelConfiguration;

namespace TutorialAPIEntity.Core.Model.Mapping
{
    public class SubjectMattersMapping : EntityTypeConfiguration<SubjectMatters>
    {
        public SubjectMattersMapping() {
            this.HasKey(e => e.Id);
            this.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}