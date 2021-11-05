using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.People.Pages.Nutritionists {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<NutritionistData> NutritionistData { get; set; }

        public async Task OnGetAsync() {
            NutritionistData = await _context.NutritionistData.ToListAsync();
        }
    }
}
