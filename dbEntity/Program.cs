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
            //GravarUsandoEntity();
            //RecuperarUsandoEntity();
            //ExluirUsandoEntity();
            //AtualizaUsandoEntity();
        }

        private static void AtualizaUsandoEntity()
        {
            using (var contexto = new LojaContext())
            {
                IList<Produto> produtos = contexto.Produtos.ToList();
                var p = produtos.First();
                p.Nome = "Cassino Royalle - Edit";
                contexto.Produtos.Update(p);
                contexto.SaveChanges();
            }
        }

        private static void ExluirUsandoEntity()
        {
            using (var contexto = new LojaContext())
            {
                IList<Produto> produtos = contexto.Produtos.ToList();
                foreach(var item in produtos)
                {
                    contexto.Produtos.Remove(item);
                }

                contexto.SaveChanges();
            }
        }

        private static void RecuperarUsandoEntity()
        {
            using (var contexto = new LojaContext())
            {
                IList<Produto> produtos = contexto.Produtos.ToList();
                Console.WriteLine("foram encontrados {0} produto(s)", produtos.Count);
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            using (var contexto = new LojaContext())
            {
                Produto p1 = new Produto();
                p1.Nome = "Harry Potter e a Ordem da Fênix";
                p1.Categoria = "Livros";
                p1.Preco = 19.89;

                Produto p2 = new Produto();
                p2.Nome = "Senhor dos Anéis 1";
                p2.Categoria = "Livros";
                p2.Preco = 19.89;

                Produto p3 = new Produto();
                p3.Nome = "O Monge e o Executivo";
                p3.Categoria = "Livros";
                p3.Preco = 19.89;

                contexto.Produtos.Add(p1);
                contexto.Produtos.Add(p2);
                contexto.Produtos.Add(p3);
                contexto.SaveChanges();
            }
        }
    }
}
