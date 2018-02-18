using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIGeo.Model.Mapping
{
    public class LabelMapping: EntityTypeConfiguration<Label>
    {
        public LabelMapping()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Id).HasColumnName("ID");
            this.Property(x => x.Texto).HasMaxLength(500).HasColumnName("TEXTO");
            this.Property(x => x.Category).HasMaxLength(500).HasColumnName("CATEGORY");
            this.Property(x => x.IdPrincipal).HasColumnName("ID_PRINCIPAL");
            this.HasRequired(x => x.Principal)
                .WithMany(y => y.Labels)
                .HasForeignKey(z => z.IdPrincipal);
            this.ToTable("LABEL");
        }
    }
}
