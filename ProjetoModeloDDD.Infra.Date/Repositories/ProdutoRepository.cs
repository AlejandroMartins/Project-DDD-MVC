using Dapper;
using ProjetoModeloDDD.Domain.Entites;
using ProjetoModeloDDD.Domain.Interfaces.Respositories;
using ProjetoModeloDDD.Domainn.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository: RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome).ToList();
            var connectionString = "Data Source = (10.10.40.4); Initial Catalog = ProjetoModeloDDD; Integrated Security = SSPI";

            using (SqlConnection conexao = new SqlConnection(
               connectionString))
            {
                return conexao.Query<Produto>(
                    "select p.nome, sum(iv.quantidade) as quantitativo, sum(iv.quantidade)*p.valor as total\r\nfrom Produtoes p, ItemVendas iv\r\nwhere iv.IdProduto = p.ProdutoId\r\ngroup by p.nome, p.valor\r\norder by sum(iv.quantidade) desc;"
                );
            }
        }

        public IEnumerable<Produto> GetGraphicProdutos()
        {
            var connectionString = "Data Source = 10.10.40.4; Initial Catalog = ProjetoModeloDDD; User ID= Homologacao; Password = Hom_3spGa91; MultipleActiveResultSets = true;";

            using (SqlConnection conexao = new SqlConnection(
               connectionString))
            {
                return conexao.Query<Produto>(
                    "select p.nome, sum(iv.quantidade) as quantitativo, sum(iv.quantidade)*p.valor as total\r\nfrom Produtoes p, ItemVendas iv\r\nwhere iv.IdProduto = p.ProdutoId\r\ngroup by p.nome, p.valor\r\norder by sum(iv.quantidade) desc;"
                );
            }


        }
        public decimal GetTicketMedio()
        {
            var connectionString = "Data Source = 10.10.40.4; Initial Catalog = ProjetoModeloDDD; User ID= Homologacao; Password = Hom_3spGa91; MultipleActiveResultSets = true;";

            using (SqlConnection conexao = new SqlConnection(
               connectionString))
            {
                return conexao.QueryFirst<decimal> (
                    "select convert(decimal(18,2),sum(iv.quantidade*p.valor)/count(v.VendaId)  )as Vendido\r\nfrom Produtoes p, ItemVendas iv, Vendas v\r\nwhere iv.IdProduto = p.ProdutoId\r\norder by sum(iv.quantidade) desc;"
                );
            }


        }


        public IEnumerable<Produto> NomeDosProdutos()
        {
            return Db.Produtos.Where(p => p.Nome != "").ToList();
        }
    }
}
