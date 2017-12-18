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
            ExluirUsandoEntity();
            GravarUsandoEntity();
            RecuperarUsandoEntity();
            AtualizaUsandoEntity();
            RecuperarUsandoEntity();
            ExluirUsandoEntity();
            RecuperarUsandoEntity();
        }

        private static void AtualizaUsandoEntity()
        {
            using (var repo = new ProdutoDAO())
            {
                IList<Produto> produtos = repo.Produto();
                Produto p = produtos.First();
                p.Nome = "edit";
                repo.Atualizar(p);
            }
        }

        private static void ExluirUsandoEntity()
        {
            using (var repo = new ProdutoDAO())
            {
                IList<Produto> produtos = repo.Produto();
                foreach(var p in produtos)
                {
                    repo.Remover(p);
                }
            }
        }

        private static void RecuperarUsandoEntity()
        {
            using (var repo = new ProdutoDAO())
            {
                IList<Produto> produtos = repo.Produto();
                Console.WriteLine("foram encontrados {0} produto(s)", produtos.Count);
                foreach (var p in produtos)
                {
                    Console.WriteLine(p);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            using (var repo = new ProdutoDAO())
            {
                Produto p1 = new Produto("Harry Potter e a Ordem da Fênix", "Livros", 19.89);
                Produto p2 = new Produto("Senhor dos Anéis 1", "Livros", 19.89);
                Produto p3 = new Produto("O Monge e o Executivo", "Livros", 19.89);

                repo.Adicionar(p1);
                repo.Adicionar(p2);
                repo.Adicionar(p3);
            }
        }
    }
}
