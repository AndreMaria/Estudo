using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIGeo.Model.Mapping
{
    public class PrincipalMapping: EntityTypeConfiguration<Principal>
    {
        public PrincipalMapping()
        {
            this.HasKey(x => x.Id);
            this.Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.Texto).HasMaxLength(500);
            this.ToTable("PRINCIPAL");
        }
    }
}
