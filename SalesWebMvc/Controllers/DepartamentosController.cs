using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> departamentos = new List<Departamento>();

            departamentos.Add(new Departamento() {Id = 1, NomeDepartamento = "Eletrônicos" });
            departamentos.Add(new Departamento() { Id = 2, NomeDepartamento = "Móveis" });
            departamentos.Add(new Departamento() { Id = 3, NomeDepartamento = "Celulares" });

            ViewData["EmailContato"] = "emailcontato@gmail.com";

            return View(departamentos);
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}
