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
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
        public IEnumerable<Produto> NomeDosProdutos()
        {
            return _produtoRepository.NomeDosProdutos();
        }

        public IEnumerable<Produto> GetGraphicProdutos()
        {
            return _produtoRepository.GetGraphicProdutos();
        }
        public decimal GetTicketMedio()
        {
            return _produtoRepository.GetTicketMedio();
        }


    }
}
