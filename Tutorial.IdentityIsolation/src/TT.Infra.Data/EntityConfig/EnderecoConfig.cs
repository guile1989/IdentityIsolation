using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TT.Domain.Entities;

namespace TT.Infra.Data.EntityConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            ToTable("Enderecos");

            HasKey(e => e.EnderecoId);
            Property(e => e.EnderecoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(150);

            Property(e => e.Numero)
                .IsRequired();
        }
    }
}
