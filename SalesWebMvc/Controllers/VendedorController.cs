using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class VendedorController : Controller
    {
        private VendedorService _vendedorService { get; set; }
        
        public VendedorController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }
        public IActionResult Index()
        {
            var vendedores = _vendedorService.Listar();

            return View(vendedores);
        }


        public IActionResult Create()
        {
            return View();
        }
    }
}
