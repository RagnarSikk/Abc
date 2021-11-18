using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.AdminView.Pages.Therapists {
    public class DeleteModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DeleteModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public TherapistData TherapistData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            TherapistData = await _context.TherapistData.FirstOrDefaultAsync(m => m.Id == id);

            if (TherapistData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            TherapistData = await _context.TherapistData.FindAsync(id);

            if (TherapistData != null) {
                _context.TherapistData.Remove(TherapistData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
