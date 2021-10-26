using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Data;
using Abc.Soft.Data;

namespace Abc.Soft.Areas.Administrators.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DeleteModel(Abc.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AdminstratorData AdminstratorData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdminstratorData = await _context.AdminstratorData.FirstOrDefaultAsync(m => m.Id == id);

            if (AdminstratorData == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AdminstratorData = await _context.AdminstratorData.FindAsync(id);

            if (AdminstratorData != null)
            {
                _context.AdminstratorData.Remove(AdminstratorData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
