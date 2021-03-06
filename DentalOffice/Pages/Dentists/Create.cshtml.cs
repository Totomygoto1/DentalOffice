﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DentalOffice.Models;

namespace DentalOffice.Pages.Dentists
{
    public class CreateModel : PageModel
    {
        private readonly DentalOffice.Models.DentalOfficeDBContext _context;

        public CreateModel(DentalOffice.Models.DentalOfficeDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dentist Dentist { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Dentist.Add(Dentist);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}