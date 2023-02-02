using Dapper;
using ProjetoModeloDDD.Domainn.Entites;
using ProjetoModeloDDD.Domainn.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Infra.Date.Repositories
{
    public class VendaRepository: RepositoryBase<Venda>, IVendaRepository
    {
        public IEnumerable<decimal> GetTicketMedio()
        {
            var connectionString = "Data Source = 10.10.40.4; Initial Catalog = ProjetoModeloDDD; User ID= Homologacao; Password = Hom_3spGa91; MultipleActiveResultSets = true;";

            using (SqlConnection conexao = new SqlConnection(
               connectionString))
            {
                return conexao.Query<decimal>(
                    "select convert(decimal(18,2),sum(iv.quantidade * p.valor) / count(v.VendaId)  )as Vendido\r\nfrom Produtoes p, ItemVendas iv, Vendas v\r\nwhere iv.IdProduto = p.ProdutoId\r\norder by sum(iv.quantidade) desc;\r\n"
                );
            }

        }

    }
}
