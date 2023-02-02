using ProjetoModeloDDD.Applications.Interface;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domainn.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Applications
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) 
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
        public IEnumerable<Produto> NomeDosProdutos()
        {
            return _produtoService.NomeDosProdutos();
        }
        public IEnumerable<Produto> GetGraphicProdutos()
        {
            var a = _produtoService.GetGraphicProdutos();
            return a;
        }
        public decimal GetTicketMedio()
        {
            return _produtoService.GetTicketMedio();
        }


    }
}
