using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration() 
        {
        
            HasKey(c => c.ClienteId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.SobreNome)
               .IsRequired()
               .HasMaxLength(150);

            Property(c => c.Email)
               .IsRequired()
               .HasMaxLength(150);




        }   
    }
}
