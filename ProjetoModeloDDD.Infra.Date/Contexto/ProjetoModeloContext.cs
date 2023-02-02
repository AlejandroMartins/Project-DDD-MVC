

using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.Infra.Data.EntityConfig;
using ProjetoModeloDDD.Infra.Date.EntityConfig;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Contexto
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext()
        : base("Connection")
        {
             
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemVenda> ItemVenda { get; set; }
        public DbSet<Venda> Venda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());
            modelBuilder.Configurations.Add(new VendaConfiguration());
            modelBuilder.Configurations.Add(new ItemVendaConfiguration());

        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = System.DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }

            }
            return base.SaveChanges();
        }

    }
    
}
