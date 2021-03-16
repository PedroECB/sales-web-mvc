using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMVC.Models
{
    [Table("departamento")]
    public class Departamento
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        public string NomeDepartamento { get; set; }

        [NotMapped]
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            NomeDepartamento = nome;
        }

        public void AddVendedor(Vendedor vendedor)
        {
            Vendedores.Add(vendedor);
        }

        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            double total = 0;

            //var vendedores = Vendedores.Where(v => v.Departamento.Equals(Nome))
            //    .Select(v => v.Vendas.Where(va => va.DataDeVenda >= dataInicial && va.DataDeVenda <= dataFinal)).ToList();

            //total += vendedores.Select(v=> v.ToList()).Select(v=> v.ve)

            total += Vendedores.Where(vendedor=> vendedor.Departamento.NomeDepartamento.Equals(NomeDepartamento))
                .Sum(vendedor => vendedor.TotalVendas(dataInicial, dataFinal));

            return total;
        }
    
    
    
    }

} //Final da classe
