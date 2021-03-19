using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using SalesWebMVC.Data;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        
        [Display(Name = "Funcionário")]
        public string Nome { get; set; }
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public double SalarioBase { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
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
