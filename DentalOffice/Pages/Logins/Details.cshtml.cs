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
    public class DetailsModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public DetailsModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        public Login Login { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Login = await _context.Login.FirstOrDefaultAsync(m => m.loginID == id);

            if (Login == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
