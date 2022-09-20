using MVCDay3Assignment2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDay3Assignment2.Models
{
    public class DepartmentEmployeeContext: DbContext
    {
        public DepartmentEmployeeContext():base("MyConnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}