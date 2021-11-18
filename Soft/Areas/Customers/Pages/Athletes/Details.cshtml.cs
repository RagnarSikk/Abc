using Abc.Data.Customers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.Customers.Pages.Athletes {
    public class DetailsModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DetailsModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

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
    }
}
