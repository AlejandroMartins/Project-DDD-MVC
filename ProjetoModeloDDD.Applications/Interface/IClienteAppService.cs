using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Applications.Interface
{
    public interface IClienteAppService: IAppServiceBase<Cliente>
    {

        IEnumerable<Cliente> GetRankingClientes();
        IEnumerable<Cliente> ObterClientesEspecias();
        int ObterNumeroDeClientes();
        

    }
}
