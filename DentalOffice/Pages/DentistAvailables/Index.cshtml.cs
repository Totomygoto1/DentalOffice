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
    public class IndexModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public IndexModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        public IList<DentistAvailable> DentistAvailable { get;set; }

        public async Task OnGetAsync()
        {
            DentistAvailable = await _context.DentistAvailable
                .Include(d => d.Dentist).ToListAsync();
        }
    }
}
