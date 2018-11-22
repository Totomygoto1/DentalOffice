using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice.Pages.Dentists
{
    public class EditModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public EditModel(DentalOffice.Models.DentalOfficeDBContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Dentist).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DentistExists(Dentist.dentistID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DentistExists(int id)
        {
            return _context.Dentist.Any(e => e.dentistID == id);
        }
    }
}
