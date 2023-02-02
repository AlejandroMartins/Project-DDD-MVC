using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public IEnumerable<Cliente> GetRankingClientes()
        {
            var connectionString = "Data Source = 10.10.40.4; Initial Catalog = ProjetoModeloDDD; User ID= Homologacao; Password = Hom_3spGa91; MultipleActiveResultSets = true;";

            using (SqlConnection conexao = new SqlConnection(
               connectionString))
            {
                return conexao.Query<Cliente>(
                    "select top 5 c.nome\r\nfrom Produtoes p, ItemVendas iv, Vendas v, Clientes c\r\nwhere iv.IdProduto = p.ProdutoId and iv.IdVenda = v.VendaId and v.IdCliente = c.ClienteId\r\ngroup by c.nome\r\norder by sum(iv.quantidade) desc;"
                );
            }


        }
    }
    
    
}
