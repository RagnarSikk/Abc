using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Data;
using Abc.Soft.Data;

namespace Abc.Soft.Areas.Administrators.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AdminstratorData> AdminstratorData { get;set; }

        public async Task OnGetAsync()
        {
            AdminstratorData = await _context.AdminstratorData.ToListAsync();
        }
    }
}
