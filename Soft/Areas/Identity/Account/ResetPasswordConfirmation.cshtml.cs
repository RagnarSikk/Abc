using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abc.Soft.Areas.Identity.Account {
    [AllowAnonymous]
    public class ResetPasswordConfirmationModel : PageModel {
        public void OnGet() {

        }
    }
}
