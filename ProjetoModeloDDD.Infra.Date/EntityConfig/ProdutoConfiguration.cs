using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration: EntityTypeConfiguration<Produto>
    {

        public ProdutoConfiguration()
        {
            HasKey(p => p.ProdutoId);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(250);


            Property(p => p.Valor)
                .IsRequired();

            Property(p => p.Quantitativo);


            Property(p => p.Total);
               






        }
    }
}
