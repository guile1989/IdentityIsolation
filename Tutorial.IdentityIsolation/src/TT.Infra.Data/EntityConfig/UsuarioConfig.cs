﻿using System.Data.Entity.ModelConfiguration;
using TT.Domain.Entities;

namespace TT.Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasKey(u => u.Id);

            Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(128);

            Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(256);

            Property(u => u.UserName)
                .IsRequired()
                .HasMaxLength(256);

            HasRequired(u => u.Clientes);

            ToTable("AspNetUsers");
        }
    }
}
