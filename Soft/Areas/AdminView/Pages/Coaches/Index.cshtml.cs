using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.AdminView.Pages.Coaches {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<CoachData> CoachData { get; set; }

        public async Task OnGetAsync() {
            CoachData = await _context.CoachData.ToListAsync();
        }
    }
}
