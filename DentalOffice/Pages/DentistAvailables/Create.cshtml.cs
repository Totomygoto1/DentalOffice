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
    public class CreateModel : PageModel
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
                               orderby d.Firstname // Sort by name.
                               select d;

            DentistNameSL = new SelectList(dentistQuery.AsNoTracking(),
                        "dentistID", "Firstname", selectedDentist);
        }



        public IActionResult OnGet()
        {
            //ViewData["dentistID"] = new SelectList(_context.Dentist, "dentistID", "dentistID");
            PopulateDentistDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public DentistAvailable DentistAvailable { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.DentistAvailable.Add(DentistAvailable);
            await _context.SaveChangesAsync();

            PopulateDentistDropDownList(_context);

            return RedirectToPage("./Index");
        }
    }
}