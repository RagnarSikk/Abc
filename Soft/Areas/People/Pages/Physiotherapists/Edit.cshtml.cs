using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.People.Pages.Physiotherapists {
    public class EditModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public EditModel(Abc.Soft.Data.ApplicationDbContext context) {
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.Attach(PhysiotherapistData).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!PhysiotherapistDataExists(PhysiotherapistData.Id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PhysiotherapistDataExists(string id) {
            return _context.PhysiotherapistData.Any(e => e.Id == id);
        }
    }
}
