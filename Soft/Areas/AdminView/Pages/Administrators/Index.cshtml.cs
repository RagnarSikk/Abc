using Abc.Data.People;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.AdminView.Pages.Administrators {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<AdministratorData> AdminstratorData { get; set; }

        public async Task OnGetAsync() {
            AdminstratorData = await _context.AdminstratorData.ToListAsync();
        }
    }
}
