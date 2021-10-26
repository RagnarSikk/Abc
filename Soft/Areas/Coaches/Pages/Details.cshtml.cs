using Abc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.Coaches.Pages {
    public class DetailsModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DetailsModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public CoachData CoachData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            CoachData = await _context.CoachData.FirstOrDefaultAsync(m => m.Id == id);

            if (CoachData == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
