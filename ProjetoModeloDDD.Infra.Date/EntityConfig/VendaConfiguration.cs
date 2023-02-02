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
    public class VendaConfiguration: EntityTypeConfiguration<Venda>
    {
       public VendaConfiguration() {
            
            HasKey(v => v.VendaId);

            Property(v => v.DataDaVenda)
                        .IsRequired();

            HasRequired(v => v.Cliente)
               .WithMany()
               .HasForeignKey(v => v.IdCliente);



        }
        

    }
}
