using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TT.Domain.Entities;

namespace TT.Infra.Data.EntityConfig
{
    public class ClienteConfig : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfig()
        {
            ToTable("Clientes");

            HasKey(c => c.ClienteId);
            Property(c => c.ClienteId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
