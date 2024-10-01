using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyManagementLibrary.ViewModel;

namespace StudyManagementASP.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public Register Model { get; set; }
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }


        public RegisterModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.UserName,
                    Email = Model.Email,
                };

                var result = await UserManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();
        }
    }
}
