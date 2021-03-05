using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SalesWebMVC.Views.Home
{
    public class AboutModel : PageModel
    {
        [ViewData]
        public string Email { get; set; }
        public void OnGet()
        {
            Email = "KKKKSDSDWE";
        }
    }
}
