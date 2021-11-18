using Abc.Data.Others;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.AdminView.Pages.Equipments {
    public class IndexModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IList<EquipmentData> EquipmentData { get; set; }

        public async Task OnGetAsync() {
            EquipmentData = await _context.EquipmentData.ToListAsync();
        }
    }
}
