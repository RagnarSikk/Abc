using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Soft.Areas.Identity.Account {
    [AllowAnonymous]
    public class ForgotPasswordConfirmation : PageModel {
        public void OnGet() {
        }
    }
}
