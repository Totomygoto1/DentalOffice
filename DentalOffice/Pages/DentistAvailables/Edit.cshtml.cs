using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;

namespace DentalOffice.Pages.DentistAvailables
{
    public class EditModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public EditModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        public SelectList DentistNameSL { get; set; }

        public void PopulateDentistDropDownList(DentalOfficeDBContext _context,
            object selectedDentist = null)
        {
            var dentistQuery = from d in _context.Dentist
                               orderby d.Lastname // Sort by name.
                               select d;

            DentistNameSL = new SelectList(dentistQuery.AsNoTracking(),
                        "dentistID", "Lastname", selectedDentist);
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
            //ViewData["dentistID"] = new SelectList(_context.Dentist, "dentistID", "dentistID");
            PopulateDentistDropDownList(_context);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DentistAvailable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DentistAvailableExists(DentistAvailable.dentistavailableID))
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

        private bool DentistAvailableExists(int id)
        {
            return _context.DentistAvailable.Any(e => e.dentistavailableID == id);
        }
    }
}
