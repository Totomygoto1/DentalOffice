using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DentalOffice.Models;
using DentalOffice.Data;

namespace DentalOffice.Pages.Visits
{
    public class EditModel : CustomerNamePageModel
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

            //ViewData["customerID"] = new SelectList(_context.Customer, "customerID", "customerID");
            //ViewData["dentistID"] = new SelectList(_context.Dentist, "dentistID", "dentistID");

            PopulateCustomerDropDownList(_context);
            PopulateDentistDropDownList(_context);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Visit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitExists(Visit.visitID))
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

        private bool VisitExists(int id)
        {
            return _context.Visit.Any(e => e.visitID == id);
        }
    }
}
