using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudyManagementLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyManagementASP.Data
{
    public class StudyDbContext : IdentityDbContext
    {
        public StudyDbContext(DbContextOptions<StudyDbContext> options) : base(options)
        {

        }

        public DbSet<Module> Module { get; set; }
    }
}
