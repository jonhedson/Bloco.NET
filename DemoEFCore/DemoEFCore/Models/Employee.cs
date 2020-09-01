using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoEFCore.Models
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public EmployeeAddress EmployeeAddress { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public virtual ICollection<EmployeesInProject> EmployeesinProject { get; set; }
    }

    public class EmployeeAddress
    {
        
        public int EmployeeId { get; set; }
        public string Address { get; set; }
        //
        //Navigation property Returns the Employee object
        public virtual Employee Employee { get; set; }
    }

    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        //Navigational Property
        public virtual ICollection<EmployeesInProject> EmployeesinProject { get; set; }
    }

    public class EmployeesInProject
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
