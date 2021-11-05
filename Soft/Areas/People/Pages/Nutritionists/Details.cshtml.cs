using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.People.Pages.Nutritionists {
    public class DetailsModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public DetailsModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public NutritionistData NutritionistData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id) {
            if (id == null) {
                return NotFound();
            }

            NutritionistData = await _context.NutritionistData.FirstOrDefaultAsync(m => m.Id == id);

            if (NutritionistData == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
