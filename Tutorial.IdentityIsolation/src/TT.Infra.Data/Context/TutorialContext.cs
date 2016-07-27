using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TT.Domain.Entities;
using TT.Infra.Data.EntityConfig;

namespace TT.Infra.Data.Context
{
    public class TutorialContext : DbContext
    {
        public TutorialContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Configurations.Add(new ClienteConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
