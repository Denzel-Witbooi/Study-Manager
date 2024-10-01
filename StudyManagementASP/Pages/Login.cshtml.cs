using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyManagementLibrary.Model;
using StudyManagementLibrary.ViewModel;

namespace StudyManagementASP.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login login { get; set; }
        public Module module { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            SignInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await SignInManager.PasswordSignInAsync(login.UserName, login.Password, login.RememberMe, false);

                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        return RedirectToPage("Index");
                    }
                    else
                    {
                        return RedirectToPage(returnUrl);
                    }
                }

                ModelState.AddModelError("", "Username or Password incorrect");
            }

            return Page();
        }
    }
}
