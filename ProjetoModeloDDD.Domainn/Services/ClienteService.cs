using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domainn.Services
{
    public class ClienteService: ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository; 
        
        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));

        }
        public int ObterNumeroDeClientes(IEnumerable<Cliente> clientes)
        {
            var numCli = 0;
            foreach (Cliente cliente in clientes)
            {
                numCli++;
            }
            return numCli;

        }

        public IEnumerable<Cliente> GetRankingClientes()
        {
            return _clienteRepository.GetRankingClientes();
        }
    }
}
