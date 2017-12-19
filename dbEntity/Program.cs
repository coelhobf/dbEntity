using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
            using (var contexto = new LojaContext())
            {
                contexto.Database.Migrate();
            }
            var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoU = 8.79, Unidade = "Litros" };
            var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoU = 12.45, Unidade = "Gramas" };
            var p3 = new Produto() { Nome = "Macarrão", Categoria = "Alimentos", PrecoU = 4.23, Unidade = "Gramas" };

            var promocaoDePascoa = new Promocao();
            promocaoDePascoa.Descricao = "Páscoa Feliz";
            promocaoDePascoa.DataInicio = DateTime.Now;
            promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

            promocaoDePascoa.IncluiProduto(p1);
            promocaoDePascoa.IncluiProduto(p2);
            promocaoDePascoa.IncluiProduto(p3);

            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                contexto.Promocoes.Add(promocaoDePascoa);
                //var promocao = contexto.Promocoes.Find(3);
                //contexto.Promocoes.Remove(promocao);
                contexto.SaveChanges();

            }
        }
    }
}
