using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Abc.Data.Others;
using Abc.Soft.Data;

namespace Abc.Soft.Areas.AdminView.Pages.Training
{
    public class IndexModel : PageModel
    {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public IndexModel(Abc.Soft.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<TrainingData> TrainingData { get;set; }

        public async Task OnGetAsync()
        {
            TrainingData = await _context.TrainingData.ToListAsync();
        }
    }
}
