using ANDRESALES.MER.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ANDRESALES.MER.Infra.Data.EntityConfig
{
    public class PerfilConfig : EntityTypeConfiguration<Perfil>
    {
        public PerfilConfig()
        {
            ToTable("Perfis");

            HasKey(p => p.Id);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(40);

            Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.Ativo)
                .IsRequired();
        }
    }
}
