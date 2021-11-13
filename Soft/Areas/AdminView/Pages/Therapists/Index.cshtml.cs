using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.AdminView.Pages.Therapists {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<TherapistData> TherapistData { get; set; }

        public async Task OnGetAsync() {
            TherapistData = await _context.TherapistData.ToListAsync();
        }
    }
}
