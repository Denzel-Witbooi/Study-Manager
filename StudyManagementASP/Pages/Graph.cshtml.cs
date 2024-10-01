using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudyManagementASP.Data;
using StudyManagementLibrary.Model;

namespace StudyManagementASP.Pages
{
    public class GraphModel : PageModel
    {

        public void OnGet()
        {

        }

        public ActionResult OnGetChartData()
        {
            var chart = new Chart
            {
                cols = new object[]
                {
            new { id = "ModuleCode", type = "string", label = "Module Code" },
            new { id = "Weeks", type = "number", label = "Weeks" }
                },
                rows = new object[]
                {
            new { c = new object[] { new { v = "PROG6211" }, new { v = 3 } } },
            new { c = new object[] { new { v = "ANTE6211" }, new { v = 1 } } },
            new { c = new object[] { new { v = "IPMA6212" }, new { v = 1 } } },
            new { c = new object[] { new { v = "SAND6212" }, new { v = 1 } } },
            new { c = new object[] { new { v = "HCIN6212" }, new { v = 2 } } }
                }
            };

            return new JsonResult(chart);
        }


    }
}
