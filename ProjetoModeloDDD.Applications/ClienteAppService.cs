using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Applications
{
    public class ClienteAppService: AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspecias()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
        public IEnumerable<Cliente> GetRankingClientes()
        {
            return _clienteService.GetRankingClientes();
        }

        public int ObterNumeroDeClientes()
        {
            return _clienteService.ObterNumeroDeClientes(_clienteService.GetAll());
        }
    }
}
