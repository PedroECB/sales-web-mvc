using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enum;


namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context { get; set; }

        public SeedingService(SalesWebMVCContext context)
        {
            _context = context;
        }


        public void Seed()
        {
            //Verificando se já existem instâncias na base de dados, caso exista, a criação dos dados é cancelada...

            if (_context.Departamento.Any()) { return; }

            //Departamanento seed

            Departamento d1 = new Departamento() { Id = 1, NomeDepartamento = "Eletrônicos" };
            Departamento d2 = new Departamento() { Id = 2, NomeDepartamento = "Livros" };
            Departamento d3 = new Departamento() { Id = 3, NomeDepartamento = "Eletrodomésticos" };


            // Vendedor seed 

            Vendedor v1 = new Vendedor()
            {
                Id = 1,
                Nome = "João Almeida Silva",
                Email = "joaozinho@gmail.com",
                DataNascimento = DateTime.Parse("03/02/1980"),
                SalarioBase = 1800.00,
                Departamento = d1
            };

            Vendedor v2 = new Vendedor()
            {
                Id = 2,
                Nome = "Joana Angélica",
                Email = "joaninha@gmail.com",
                DataNascimento = DateTime.Parse("05/06/1948"),
                SalarioBase = 2100.00,
                Departamento = d2
            };

            Vendedor v3 = new Vendedor()
            {
                Id = 3,
                Nome = "Américo Silveira Silva",
                Email = "silviomerico@yahoo.com.br",
                DataNascimento = DateTime.Parse("09/06/1997"),
                SalarioBase = 1320.00,
                Departamento = d1
            };

            //Vendas seed

            Venda venda1 = new Venda()
            {
                Id = 0993,
                DataDeVenda = DateTime.Parse("09/03/2020"),
                Total = 122.00,
                Status = StatusVenda.Aprovada,
                Vendedor = v1
            };

            Venda venda2 = new Venda()
            {
                Id = 0313,
                DataDeVenda = DateTime.Parse("19/02/2021"),
                Total = 382.00,
                Status = StatusVenda.Cancelada,
                Vendedor = v1
            };
             

            _context.Departamento.AddRange(d1, d2, d3);
            _context.Vendedor.AddRange(v1, v2, v3);
            _context.Venda.AddRange(venda1, venda2);

            _context.SaveChanges();
        }
    }
}
