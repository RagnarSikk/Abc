using Abc.Data.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.Customers.Pages.Athletes {
    public class EditModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public EditModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public AthleteData AthleteData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            AthleteData = await _context.AthleteData.FirstOrDefaultAsync(m => m.Id == id);

            if (AthleteData == null) {
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

            _context.Attach(AthleteData).State = EntityState.Modified;

            try {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) {
                if (!AthleteDataExists(AthleteData.Id)) {
                    return NotFound();
                }
                else {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AthleteDataExists(string id) {
            return _context.AthleteData.Any(e => e.Id == id);
        }
    }
}
