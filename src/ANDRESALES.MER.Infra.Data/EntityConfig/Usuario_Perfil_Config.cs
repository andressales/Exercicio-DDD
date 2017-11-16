using ANDRESALES.MER.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ANDRESALES.MER.Infra.Data.EntityConfig
{
    public class UsuarioPerfilConfig : EntityTypeConfiguration<UsuarioPerfil>
    {
        public UsuarioPerfilConfig()
        {
            ToTable("UsuarioPerfil");

            HasKey(p => new { p.IdUsuario, p.IdPerfil });

            HasRequired(p => p.Usuario)
                .WithMany(p => p.ListaPerfil)
                .HasForeignKey(p => p.IdUsuario);

            HasRequired(p => p.Perfil)
                .WithMany(p => p.ListaUsuario)
                .HasForeignKey(p => p.IdPerfil);
        }
    }
}
