using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.Domainn.Interfaces.Repositories;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Services
{
    public class VendaService : ServiceBase<Venda>, IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
            : base(vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IEnumerable<decimal> GetTicketMedio()
        {
            return _vendaRepository.GetTicketMedio();
        }
    }
}
