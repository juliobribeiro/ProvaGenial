﻿using System;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using ProvaGenialInvestimentos.Domain.Entities;

namespace ProvaGenialInvestimentos.Data.EntityConfig
{
    public class CategoriaConfig : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfig()
        {
            HasKey(c => c.IdCategoria);

            Property(c => c.NomeCategoria)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.DataInclusao)
                .IsRequired();
        }
    }
}
