using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntity
{
   public class Promocao
    {
        public int Id { get; internal set; }
        public int Nome { get; internal set; }
        public int Categoria { get; internal set; }
        public int PrecoUnitario { get; internal set; }
        public string Unidade { get; set; }
        public IList<Promocao> Promocoes { get; set; }

        public override string ToString()
        {
            return $"Produto: {this.Id}, {this.Nome}, {this.Categoria}, {this.PrecoUnitario}";
        }
    }
}
