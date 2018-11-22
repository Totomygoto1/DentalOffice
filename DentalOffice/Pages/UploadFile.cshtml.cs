using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.IO;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace DentalOffice.Pages
{

    public class UploadFileModel : PageModel
    {
        private IHostingEnvironment _environment;

        public UploadFileModel(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public IFormFile Upload { get; set; }

        public async Task OnPostAsync()
        {
            var fileName = WebUtility.HtmlEncode(
            Path.GetFileName(Upload.FileName));

            var file = "C:\\uploads\\" + fileName;
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Upload.CopyToAsync(fileStream);
            }
        }
    }
}
