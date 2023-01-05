﻿using Loren.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loren.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(p => p.Imagem)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Valor)
                .IsRequired()
                .HasColumnType("decimal(14,2)");

            builder.ToTable("Produtos");
        }
    }
}
