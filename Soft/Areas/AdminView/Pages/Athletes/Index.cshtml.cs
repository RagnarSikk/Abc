using Abc.Data.Customers;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.AdminView.Pages.Athletes {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<AthleteData> AthleteData { get; set; }

        public async Task OnGetAsync() {
            AthleteData = await _context.AthleteData.ToListAsync();
        }
    }
}
