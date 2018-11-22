using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice.Pages.Logins
{
    public class IndexModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public IndexModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        public IList<Login> Login { get;set; }

        public async Task OnGetAsync()
        {
            Login = await _context.Login.ToListAsync();
        }
    }
}
