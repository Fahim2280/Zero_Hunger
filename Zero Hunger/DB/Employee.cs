using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zero_Hunger.DB
{
    public class Employee
    {
        [Required]
        public int EmployeeID { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public int EmployeeCont { get; set; }
        [Required]
        public string EmployeeEmail { get; set; }
        [Required]
        public string EmployeeGender { get; set; }
        [Required]
        public string EmployeeAddress{ get; set; }

        public virtual ICollection<EmployeeAssingn> EmployeeAssingns { get; set; }
    }
}