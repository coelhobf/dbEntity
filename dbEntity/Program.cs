using Microsoft.EntityFrameworkCore;
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

            var paoFrances = new Produto("Pão Francês", "Padaria", 0.40, "Unidade");
            var compra = new Compra(paoFrances, 6);

            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);
                contexto.SaveChanges();
            }
        }
    }
}
