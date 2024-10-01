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
    public class EditModuleModel : PageModel
    {
        public UserManager<IdentityUser> UserManager { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; }
        [BindProperty]
        public Module Module { get; set; }

        StudyDbContext _Context;

        public EditModuleModel(SignInManager<IdentityUser> signInManager, StudyDbContext databaseContext)
        {
            SignInManager = signInManager;
            _Context = databaseContext;
        }
        public void OnGet(int? id)
        {
            if (id != null)
            {

                var data = (from module in _Context.Module
                            where module.Id == id
                            select module).SingleOrDefault();
                Module = data;
            }
        }

        public ActionResult OnPost()
        {
            var module = Module;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _Context.Entry(module).Property(x => x.ModuleCode).IsModified = true;
            _Context.Entry(module).Property(x => x.ModuleName).IsModified = true;
            _Context.SaveChanges();
            return RedirectToPage("AllModule");
        }
    }
}
