using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Applications.Interface
{
    public interface IProdutoAppService: IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
        IEnumerable<Produto> NomeDosProdutos();
        IEnumerable<Produto> GetGraphicProdutos();
        decimal GetTicketMedio();


    }
}
