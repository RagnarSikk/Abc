﻿using Abc.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Abc.Soft.Areas.Physiotherapists.Pages {
    public class CreateModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public CreateModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public PhysiotherapistData PhysiotherapistData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.PhysiotherapistData.Add(PhysiotherapistData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
