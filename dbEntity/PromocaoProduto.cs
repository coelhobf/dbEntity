using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntity
{
    class PromocaoProduto
    {
        public int IdProduto { get; set; }
        public int idPromocao { get; set; }
        public Produto Produto { get; set; }
        public Promocao Promocao { get; set; }
    }
}
