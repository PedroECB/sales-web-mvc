using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;
using SalesWebMVC.Data;

namespace SalesWebMVC.Services
{
    public class VendedorService
    {
        private SalesWebMVCContext _context { get; set; }
        
        public VendedorService(SalesWebMVCContext context)
        {
            _context = context;
        }


        public List<Vendedor> Listar()
        {
            return _context.Vendedor.ToList();
        }
    }
}
