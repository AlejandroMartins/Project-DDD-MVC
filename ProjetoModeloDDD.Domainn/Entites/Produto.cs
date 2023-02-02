using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoModeloDDD.Domain.Entites
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantitativo { get; set; }
        public decimal Total { get; set; }

    }
}
