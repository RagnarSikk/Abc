using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.People.Pages.Physiotherapists {
    public class DetailsModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DetailsModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

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
    }
}
