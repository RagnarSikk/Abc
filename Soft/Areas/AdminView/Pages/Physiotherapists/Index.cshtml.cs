using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Abc.Soft.Areas.AdminView.Pages.Physiotherapists {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<PhysiotherapistData> PhysiotherapistData { get; set; }

        public async Task OnGetAsync() {
            PhysiotherapistData = await _context.PhysiotherapistData.ToListAsync();
        }
    }
}
