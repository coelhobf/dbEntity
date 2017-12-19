using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntity
{
    public class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double PrecoU { get; internal set; }
        public string Unidade { get; set; }
        public IList<Promocao> Promocoes { get; set; }

        public override string ToString()
        {
            return $"Produto: {this.Id}, {this.Nome}, {this.Categoria}, {this.PrecoU}";
        }

        public Produto(string nome, string categoria, double preco, string unidade = "")
        {
            Nome = nome;
            Categoria = categoria;
            PrecoU = preco;
            this.Unidade = unidade;
        }
        public Produto() {  }
    }
}

