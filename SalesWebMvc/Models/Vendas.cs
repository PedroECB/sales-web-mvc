using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models.Enum;

namespace SalesWebMVC.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime DataDeVenda { get; set; }

        public double Valor { get; set; }

        public StatusVenda Status { get; set; }
    }
}
