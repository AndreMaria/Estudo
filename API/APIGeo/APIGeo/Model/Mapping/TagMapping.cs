using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIGeo.Model.Mapping
{
    public class TagMapping: EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Id).HasColumnName("ID");
            this.Property(x => x.TagTexto).HasColumnName("TAG_TEXTO");
            this.Property(x => x.TagNormalized).HasColumnName("TAG_NORMALIZED");
            this.Property(x => x.IdPrincipal).HasColumnName("ID_PRINCIPAL");

            this.HasRequired(x => x.Principal)
                .WithMany(y => y.Tags)
                .HasForeignKey(z => z.IdPrincipal);
            this.ToTable("TAG");
        }
    }
}
