using System.Threading.Tasks;
using Abc.Data.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Soft.Areas.People.Pages.Coaches {
    public class CreateModel : PageModel {
        private readonly Abc.Soft.Data.ApplicationDbContext _context;

        public CreateModel(Abc.Soft.Data.ApplicationDbContext context) {
            _context = context;
        }

        public IActionResult OnGet() {
            return Page();
        }

        [BindProperty]
        public CoachData CoachData { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            _context.CoachData.Add(CoachData);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
