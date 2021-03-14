using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBase { get; set; }
        public DateTime DataNascimento { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, double salarioBase, DateTime dataNascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataNascimento = dataNascimento;
            Departamento = departamento;
        }

        public void AddVenda(Venda venda)
        {
            Vendas.Add(venda);
        }

        public void RemoveVenda(Venda venda)
        {
            Vendas.Remove(venda);

        }

        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            double total = 0;

            total += Vendas.Where(v => v.DataDeVenda >= dataInicial && v.DataDeVenda <= dataFinal)
                .Select(v => v.Total)
                .Sum();

            return total;
        }
    }
}
