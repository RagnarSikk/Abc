using Abc.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.Physiotherapists.Pages {
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
