using DentalOffice.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DentalOffice.Models
{
    public class DentistNamePageModel : PageModel
    {
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
    }
}
