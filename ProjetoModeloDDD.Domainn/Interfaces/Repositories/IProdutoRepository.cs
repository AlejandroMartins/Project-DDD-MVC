using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Interfaces.Respositories
{
    public interface IProdutoRepository: IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);

        IEnumerable<Produto> NomeDosProdutos();

        IEnumerable<Produto> GetGraphicProdutos();

        decimal GetTicketMedio();





    }
}
