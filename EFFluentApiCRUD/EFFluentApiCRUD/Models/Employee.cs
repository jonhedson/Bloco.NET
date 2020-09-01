using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFFluentApiCRUD.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
