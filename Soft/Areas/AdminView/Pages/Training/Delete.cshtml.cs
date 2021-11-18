using Abc.Data.Others;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.AdminView.Pages.Training {
    public class DeleteModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DeleteModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        [BindProperty]
        public TrainingData TrainingData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            TrainingData = await _context.TrainingData.FirstOrDefaultAsync(m => m.Id == id);

            if (TrainingData == null) {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            TrainingData = await _context.TrainingData.FindAsync(id);

            if (TrainingData != null) {
                _context.TrainingData.Remove(TrainingData);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
