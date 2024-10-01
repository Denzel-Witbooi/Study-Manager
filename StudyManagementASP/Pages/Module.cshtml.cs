using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyManagementASP.Data;
using StudyManagementLibrary.Model;

namespace StudyManagementASP.Pages
{
    [Authorize]
    public class ModuleModel : PageModel
    {
        [BindProperty]
        public Module Module { get; set; }

        public UserManager<IdentityUser> UserManager { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; }

        StudyDbContext _Context;

        public ModuleModel(SignInManager<IdentityUser> signInManager, StudyDbContext databaseContext)
        {
            SignInManager = signInManager;
            _Context = databaseContext;
        }

        public void OnGet()
        {

        }

        public ActionResult OnPost()
        {
            if (SignInManager.IsSignedIn(User))
                Module.UserName = User.Identity.Name;
            Module.SelfStudyHrsReq = Module.Credits * 10 / Module.SemesterWeek - Module.ClassHrsPW;
            Module.SelfStudyHrsRem = Module.SelfStudyHrsReq - Module.HoursWorked;
            Module.Weeks = (Module.DateStudied.Day + ((int)Module.DateStudied.DayOfWeek)) / 7 + 1;
            {
                var module = Module;

                if (!ModelState.IsValid)
                {
                    return Page();
                }
                var result = _Context.Add(module);
                _Context.SaveChanges(); // Saving Data in database
            }


            return RedirectToPage("AllModule");
        }
    }
}
