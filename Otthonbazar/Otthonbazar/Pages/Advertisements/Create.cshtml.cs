using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Otthonbazar.Data;

namespace Otthonbazar.Pages.Advertisements
{

    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Otthonbazar.Data.ApplicationDbContext _context;

        public CreateModel(Otthonbazar.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CityId"] = new SelectList(_context.Set<City>(), "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Advertisement Advertisement { get; set; }

        public ActionResult OnGetZip(int zip) => new JsonResult(_context.Set<City>().FirstOrDefault(c => c.Zip
        == zip.ToString()));

        public async Task<IActionResult> OnPostAsync(Advertisement advertisement, IFormFile uploadImage,
[FromServices] IHostingEnvironment hostingEnvironment)
        {
            if (ModelState.IsValid)
            {
                // Save File
                if (uploadImage != null && uploadImage.Length > 0)
                {
                    var webRoot = hostingEnvironment.WebRootPath;
                    advertisement.ImageUrl = $"image-{DateTime.UtcNow.ToString("yyyyMMdd-HHmmss")}.jpg";
                    // It will save in the wwwroot/images library.
                    var filePath = Path.Combine(webRoot, "images", advertisement.ImageUrl);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await uploadImage.CopyToAsync(stream);
                    }
                }
                // Read of the city based on the zip code.
                var city = _context.Set<City>().Single(c => c.Zip == advertisement.City.Zip);
                advertisement.City = city;
                // Save the advertisement data into the DB.
                _context.Add(advertisement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return Page();
        }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return Page();
        //    }

        //    _context.Advertisement.Add(Advertisement);
        //    await _context.SaveChangesAsync();

        //    return RedirectToPage("./Index");
        //}
    }
}