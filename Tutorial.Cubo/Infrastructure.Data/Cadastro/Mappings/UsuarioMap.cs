using System.Data.Entity.ModelConfiguration;
using Domain.Cadastro.Entities;

namespace Infrastructure.Data.Cadastro.Mappings
{
    public class UsuarioMap:EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            base.ToTable("TB_Usuario", "DBUSER");
            base.HasKey(e => e.Id); //.WithPrimaryKeyColumn("Id", DbType.Int32).AsIdentity();
            base.Property(e => e.Id).HasColumnName("UsuarioId");
            base.Property(e => e.Id).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);

            base.Property(e => e.Nome).HasColumnName("USUARIONOME");
            base.Property(e => e.Senha).HasColumnName("USUARIOSENHA");
            base.Property(e => e.Email).HasColumnName("USUARIOEMAIL");
        }
    }
}
