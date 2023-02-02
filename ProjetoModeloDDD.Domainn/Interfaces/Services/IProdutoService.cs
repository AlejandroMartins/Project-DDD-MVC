using ProjetoModeloDDD.Domain.Entites;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domainn.Interfaces.Services
{
    public interface IProdutoService: IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
        IEnumerable<Produto> NomeDosProdutos();
        IEnumerable<Produto> GetGraphicProdutos();
        decimal GetTicketMedio();

    }
}
