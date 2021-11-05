using System.Linq;
using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.People.Pages.Therapists {
    public class EditModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public EditModel(Abc.Soft.Data.ApplicationDbContext context) {
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(TherapistData).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!TherapistDataExists(TherapistData.Id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TherapistDataExists(string id) {
            return _context.TherapistData.Any(e => e.Id == id);
        }
    }
}
