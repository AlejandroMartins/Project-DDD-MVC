using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Entites
{
    public class ItemVenda
    {
        public int ItemVendaId { get; set; }
        public int quantidade { get; set; }
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }
        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }

    }
}
