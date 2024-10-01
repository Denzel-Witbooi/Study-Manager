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
    public class AllModuleModel : PageModel
    {
        public UserManager<IdentityUser> UserManager { get; set; }
        public SignInManager<IdentityUser> SignInManager { get; }

        StudyDbContext _Context;

        public AllModuleModel(SignInManager<IdentityUser> signInManager, StudyDbContext databaseContext)
        {
            SignInManager = signInManager;
            _Context = databaseContext;
        }

        public List<Module> ModuleList { get; set; }

        public void OnGet()
        {
            var data = (from moduleList in _Context.Module
                        where moduleList.UserName.Equals(User.Identity.Name)
                        select moduleList).ToList();

            ModuleList = data;
        }

        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {

                var data = (from module in _Context.Module
                            where module.Id == id
                            select module).SingleOrDefault();

                _Context.Remove(data);
                _Context.SaveChanges();
            }
            return RedirectToPage("AllModule");
        }
    }
}
