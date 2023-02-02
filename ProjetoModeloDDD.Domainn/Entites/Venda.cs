using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Entites
{
    public class Venda
    {

        public int VendaId { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataDaVenda  { get; set; }
        public virtual Cliente Cliente { get; set; }

    }

}
