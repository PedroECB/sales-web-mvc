using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models.Enum;

namespace SalesWebMVC.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataDeVenda { get; set; }

        public double Total { get; set; }

        public StatusVenda Status { get; set; }

        public Vendedor Vendedor { get; set; }

        public Venda()
        {

        }

        public Venda(int id, DateTime dataDeVenda, double total, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            DataDeVenda = dataDeVenda;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
