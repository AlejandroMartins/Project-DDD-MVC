using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Applications
{
    public class ItemVendaAppService : AppServiceBase<ItemVenda>, IItemVendaAppService
    {
        private readonly IItemVendaService _itemVendaService;
        
        public ItemVendaAppService(IItemVendaService itemVendaService)
            : base(itemVendaService)
        {
            _itemVendaService = itemVendaService;
        }
    }
}
