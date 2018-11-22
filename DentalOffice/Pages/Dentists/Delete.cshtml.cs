using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice.Pages.Dentists
{
    public class DeleteModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public DeleteModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Dentist Dentist { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Dentist = await _context.Dentist.FirstOrDefaultAsync(m => m.dentistID == id);

            if (Dentist == null)
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

            Dentist = await _context.Dentist.FindAsync(id);

            if (Dentist != null)
            {
                _context.Dentist.Remove(Dentist);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
