using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.AdminView.Pages.Physiotherapists {
    public class DeleteModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DeleteModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public PhysiotherapistData PhysiotherapistData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            PhysiotherapistData = await _context.PhysiotherapistData.FirstOrDefaultAsync(m => m.Id == id);

            if (PhysiotherapistData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            PhysiotherapistData = await _context.PhysiotherapistData.FindAsync(id);

            if (PhysiotherapistData != null) {
                _context.PhysiotherapistData.Remove(PhysiotherapistData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
