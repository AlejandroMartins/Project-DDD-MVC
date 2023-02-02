using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using ProjetoModeloDDD.Domainn.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Applications
{
    public class VendaAppService : AppServiceBase<Venda>, IVendaAppService
    {
        private readonly IVendaService _vendaService;

        public VendaAppService(IVendaService vendaService)
            : base(vendaService)
        {
            _vendaService = vendaService;
        }

        public IEnumerable<decimal> GetTicketMedio()
        {
            var a = _vendaService.GetTicketMedio();
            return a;
        }
    }
}
