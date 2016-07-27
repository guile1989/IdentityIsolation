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

            Property(e => e.Bairro)
                .IsRequired()
                .HasMaxLength(50);

            Property(e => e.CEP)
                .IsRequired()
                .HasMaxLength(8);

            Property(e => e.Complemento)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(100);

            Property(e => e.Cidade)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
