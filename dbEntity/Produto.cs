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
        public double PrecoU { get; internal set; }
        public string Unidade { get; set; }

        public override string ToString()
        {
            return "Produto: " + Nome + ", Preco: " + PrecoU + ", Categoria: " + Categoria + ", Unidade: " + Unidade; 
        }

        public Produto(string nome, string categoria, double preco, string unidade = "")
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.PrecoU = preco;
            this.Unidade = unidade;
        }
    }
}

