using ProjetoModeloDDD.Domain.Entites;
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
    public class ItemVendaService : ServiceBase<ItemVenda>, IItemVendaService
    {
        private readonly IItemVendaRepository _itemVendaRepository;

        public ItemVendaService(IItemVendaRepository itemVendaRepository)
            : base(itemVendaRepository)
        {
            _itemVendaRepository = itemVendaRepository;
        }
    }
}
