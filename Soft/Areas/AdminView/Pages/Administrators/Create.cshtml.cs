﻿using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Soft.Areas.AdminView.Pages.Administrators {
    public class CreateModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public CreateModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public AdministratorData AdminstratorData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.AdminstratorData.Add(AdminstratorData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
