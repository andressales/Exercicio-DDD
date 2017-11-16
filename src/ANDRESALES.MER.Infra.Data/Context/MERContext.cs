using ANDRESALES.MER.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ANDRESALES.MER.Infra.Data.Context
{
    public class MERContext : DbContext
    {
        public MERContext() 
            : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //* Entity Config
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new PerfilConfig());
            modelBuilder.Configurations.Add(new UsuarioPerfilConfig());
            modelBuilder.Configurations.Add(new AcessoConfig());
            modelBuilder.Configurations.Add(new LocalConfig());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(10));

            base.OnModelCreating(modelBuilder);
        }
    }
}
