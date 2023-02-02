using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Respositories
{
    public interface IClienteRepository : IRepositoryBase<Cliente>
    {
        IEnumerable<Cliente> GetRankingClientes();
    }
}
