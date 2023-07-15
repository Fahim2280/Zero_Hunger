using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Zero_Hunger.DB
{
    public class ZeroContext : DbContext
    {
        public  DbSet<Employee> Employees { get; set; }
        public  DbSet<Restaurant> Restaurants { get; set;}
        public  DbSet<EmployeeAssingn> EmployeesAssingn { get; set; }
    }
}