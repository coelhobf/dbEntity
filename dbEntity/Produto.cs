using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntity
{
    internal class Produto
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Categoria { get; internal set; }
        public double Preco { get; internal set; }

        public override string ToString()
        {
            return "Produto: " + Nome + ", Preco: " + Preco + ", Categoria: " + Categoria; 
        }

        public Produto(string nome, string categoria, double preco)
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.Preco = preco;
        }
    }
}

