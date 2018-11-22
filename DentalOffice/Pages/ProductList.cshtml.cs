using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DentalOffice.Models;

namespace DentalOffice.Pages
{

    // Implementation of Dependency Injection Pattern in C#

    public class ProductListModel : PageModel
    {
        public List<string> productlist1 = new List<string>();

        public List<string> productlist2 = new List<string>();

        public string title1 { get; set; }

        public string title2 { get; set; }


        public IActionResult OnGet()
        {
            title1 = "Toothpaste";

            Service1 s1 = new Service1();
            
            Client c1 = new Client(s1);

            productlist1 = c1.ServeMethod();

            title2 = "Dental floss";

            Service2 s2 = new Service2();
            
            Client c2 = new Client(s2);

            productlist2 = c2.ServeMethod();

            return Page();
            
        }
    }
}