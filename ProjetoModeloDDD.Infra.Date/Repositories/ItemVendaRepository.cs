using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.Domainn.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Date.Repositories
{
    public class ItemVendaRepository: RepositoryBase<ItemVenda>, IItemVendaRepository
    {
    }
}
