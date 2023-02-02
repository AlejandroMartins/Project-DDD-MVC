using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Date.EntityConfig
{
    public class ItemVendaConfiguration: EntityTypeConfiguration<ItemVenda>
    {

        public ItemVendaConfiguration()
        {
            HasKey(iv => iv.ItemVendaId);

            Property(iv => iv.quantidade)
                    .IsRequired();

            HasRequired(iv => iv.Venda)
               .WithMany()
               .HasForeignKey(v => v.IdVenda);

            HasRequired(iv => iv.Produto)
               .WithMany()
               .HasForeignKey(p => p.IdProduto);

        }
        

    }
}
