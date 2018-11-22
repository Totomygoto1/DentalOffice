using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice.Pages.DentistAvailables
{
    public class DeleteModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public DeleteModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DentistAvailable DentistAvailable { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DentistAvailable = await _context.DentistAvailable
                .Include(d => d.Dentist).FirstOrDefaultAsync(m => m.dentistavailableID == id);

            if (DentistAvailable == null)
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

            DentistAvailable = await _context.DentistAvailable.FindAsync(id);

            if (DentistAvailable != null)
            {
                _context.DentistAvailable.Remove(DentistAvailable);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
