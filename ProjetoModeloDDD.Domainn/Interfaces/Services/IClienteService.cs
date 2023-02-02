using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Interfaces.Services
{
    public interface IClienteService: IServiceBase<Cliente>
    {
        IEnumerable<Cliente> GetAll();
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
        IEnumerable<Cliente> GetRankingClientes();
        int ObterNumeroDeClientes(IEnumerable<Cliente> clientes);
    }
}
