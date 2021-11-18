using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.People.Pages.Administrators {
    public class DeleteModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DeleteModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public AdministratorData AdminstratorData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            AdminstratorData = await _context.AdminstratorData.FirstOrDefaultAsync(m => m.Id == id);

            if (AdminstratorData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            AdminstratorData = await _context.AdminstratorData.FindAsync(id);

            if (AdminstratorData != null) {
                _context.AdminstratorData.Remove(AdminstratorData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
