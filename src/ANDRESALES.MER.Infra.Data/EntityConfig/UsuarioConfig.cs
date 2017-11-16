using ANDRESALES.MER.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANDRESALES.MER.Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            ToTable("Usuarios");

            HasKey(p => p.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(40);

            Property(p => p.Sobrenome)
                .IsRequired()
                .HasMaxLength(80);

            Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength();

            Property(p => p.Ativo)
                .IsRequired();

            Property(p => p.DataCriacao)
                .IsRequired();

            HasMany(p => p.ListaLocal)
                .WithMany(p => p.ListaUsuario)
                .Map(map => {
                    map.MapLeftKey("IdUsuario");
                    map.MapRightKey("IdLocal");
                    map.ToTable("Usuario_Local");
                });
        }
    }
}
