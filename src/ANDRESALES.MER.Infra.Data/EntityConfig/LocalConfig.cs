using ANDRESALES.MER.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ANDRESALES.MER.Infra.Data.EntityConfig
{
    public class LocalConfig : EntityTypeConfiguration<Local>
    {
        public LocalConfig()
        {
            ToTable("Locais");

            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(40);

            HasMany(p => p.ListaUsuario)
                .WithMany(p => p.ListaLocal)
                .Map(map => {
                    map.MapLeftKey("IdLocal");
                    map.MapRightKey("IdUsuario");
                    map.ToTable("UsuarioLocal");
                });
        }
    }
}
