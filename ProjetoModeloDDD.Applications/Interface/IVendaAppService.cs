using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Applications.Interface
{
    public interface IVendaAppService : IAppServiceBase<Venda>
    {
        IEnumerable<decimal> GetTicketMedio();
    }
}
