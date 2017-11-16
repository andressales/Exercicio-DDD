using ANDRESALES.MER.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace ANDRESALES.MER.Infra.Data.EntityConfig
{
    public class AcessoConfig : EntityTypeConfiguration<Acesso>
    {
        public AcessoConfig()
        {
            ToTable("Acessos");

            HasKey(p => p.Id);

            Property(p => p.Code)
                .IsRequired()
                .HasMaxLength(10);

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(40);

            HasRequired(p => p.Perfil)
                .WithMany(p => p.ListaAcesso)
                .HasForeignKey(p => p.IdPerfil);
        }
    }
}
