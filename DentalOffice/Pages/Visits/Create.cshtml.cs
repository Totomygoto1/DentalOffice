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
    public class CreateModel : CustomerNamePageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public CreateModel(DentalOffice.Models.DentalOfficeDBContext context)
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

        public IActionResult OnGet()
        {

            PopulateCustomerDropDownList(_context);
            PopulateDentistDropDownList(_context);
            
            return Page();
        }

        [BindProperty]
        public Visit Visit { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyVisit = new Visit();

            if (await TryUpdateModelAsync<Visit>(
                 emptyVisit,
                 "visit",   // Prefix for form value.
                 s => s.visitID, s => s.customerID, s => s.dentistID, s => s.visitDate, s => s.notes, s => s.image1, s => s.image2, s => s.image3, s => s.author))
            {
                _context.Visit.Add(emptyVisit);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            PopulateCustomerDropDownList(_context, emptyVisit.customerID);

            PopulateDentistDropDownList(_context, emptyVisit.dentistID);

            return Page();


        }
    }
}