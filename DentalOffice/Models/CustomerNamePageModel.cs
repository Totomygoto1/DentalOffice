using DentalOffice.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DentalOffice.Models
{
    public class CustomerNamePageModel : PageModel
    {
        public SelectList CustomerNameSL { get; set; }

        public void PopulateCustomerDropDownList(DentalOfficeDBContext _context,
            object selectedCustomer = null)
        {
            var customersQuery = from c in _context.Customer
                                   orderby c.Lastname // Sort by name.
                                   select c;

            CustomerNameSL = new SelectList(customersQuery.AsNoTracking(),
                        "customerID", "Lastname", selectedCustomer);
        }
    }
}
