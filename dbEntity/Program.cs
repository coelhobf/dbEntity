using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbEntity
{
    public class Program
    {
        static void Main(string[] args)
        {
            GravarUsandoEntity();
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Livro x";
            p.Categoria = "Livros";
            p.Preco = 10;

            using (var contexto = new LojaContext())
            {
                contexto.Adicionar(p);
            }
        }
    }
}
