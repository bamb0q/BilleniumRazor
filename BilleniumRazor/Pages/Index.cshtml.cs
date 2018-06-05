using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilleniumRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BilleniumRazor.Pages
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public User User { get; set; }

        public async Task OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Users.Add(User);
            await _db.SaveChangesAsync();
            return RedirectToPage("End");
        }
    }
}
