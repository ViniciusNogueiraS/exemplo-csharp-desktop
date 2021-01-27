using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Produto
    {
        public decimal id = 0;
        public string descricao = "";
        public decimal preco = 0;

        public Produto(decimal id, string descricao, decimal preco)
        {
            this.id = id;
            this.descricao = descricao;
            this.preco = preco;
        }

    }
}
