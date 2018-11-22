using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice.Pages.Visits
{
    public class DeleteModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public DeleteModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Visit Visit { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Visit = await _context.Visit
                .Include(v => v.Customer)
                .Include(v => v.Dentist).FirstOrDefaultAsync(m => m.visitID == id);

            if (Visit == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Visit = await _context.Visit.FindAsync(id);

            if (Visit != null)
            {
                _context.Visit.Remove(Visit);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
