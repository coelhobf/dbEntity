using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public Cliente() { }
        public Cliente(string nome, Endereco endereco)
        {
            this.Nome = nome;
            this.Endereco = endereco;
        }

        public Cliente(string nome, int numero, string logra, string comple, string bairro, string cidade)
        {
            this.Nome = nome;
            this.Endereco = new Endereco(numero, logra, comple, bairro, cidade);
        }
    }
}
