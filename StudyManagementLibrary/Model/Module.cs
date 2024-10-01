using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementLibrary.Model
{
    [Table("Module")]
    public class Module
    {
        [Key] //Tells system this is a PK
        public int Id { get; set; }
        /* Properties changed to match the table tblModules in StudentDB */
        #region module properties using propfull shortcut
        public string UserName { get; set; }
        [DisplayName("Module Code")]
        [Required]
        public string ModuleCode { get; set; }
        [DisplayName("Module Name")]
        [Required]
        public string ModuleName { get; set; }
        [Required]
        public int Credits { get; set; }
        [DisplayName("Class Hours Per Week")]
        [Required]
        public int ClassHrsPW { get; set; }

        [DisplayName("Start Date")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [DisplayName("Semester Week")]
        [Required]
        public int SemesterWeek { get; set; }

        [DisplayName("Date Studied")]
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DateStudied { get; set; }

        [DisplayName("Hours Worked")]
        [Required]
        public int HoursWorked { get; set; }
        #endregion

        #region properties that return a calculated value
        [DisplayName("Self Study Hours Required")]
        public int SelfStudyHrsReq { get; set; }

        [DisplayName("Self Study Hours Remaining")]
        public int SelfStudyHrsRem { get; set; }
        public int Weeks { get; set; }

        #endregion
    }
}
