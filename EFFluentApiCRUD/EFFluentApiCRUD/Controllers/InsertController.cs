using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFFluentApiCRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFFluentApiCRUD.Controllers
{
    public class InsertController : Controller
    {
        public IActionResult InsertSingle()
        {
            var dept = new Department()
            {
                Name = "Design"
            };

            using (var context = new EFFluentApiCRUDContext())
            {
                context.Department.Add(dept);
                context.SaveChanges();
            }
            return View("Common");
        }

        public async Task<IActionResult> InsertSingleAsyn()
        {
            var dept = new Department()
            {
                Name = "Design"
            };

            using (var context = new EFFluentApiCRUDContext())
            {
                context.Add(dept);
                await context.SaveChangesAsync();
            }
            return View("Common");

        }

        public async Task<IActionResult> InsertMultiple()
        {
            var dept1 = new Department() { Name = "Developement" };
            var dept2 = new Department() { Name = "HR" };
            var dept3 = new Department() { Name = "Marketing" };

            //var deps = new List<Department>() { dept1, dept2, dept3 };

            using (var context = new EFFluentApiCRUDContext())
            {
                context.AddRange(dept1, dept2, dept3);
                //Adicionando pela Lista
                //context.AddRange(deps);

                await context.SaveChangesAsync();
            }
            return View("Common");

        }

        public async Task<IActionResult> InsertRelated()
        {
            var dept = new Department()
            {
                
                Name = "Admin"
            };

            var emp = new Employee()
            {
                Name = "Matt",
                Designation = "Head",
                Department = dept
            };

            using (var context = new EFFluentApiCRUDContext())
            {
                context.Add(emp);
                await context.SaveChangesAsync();
            }
            return View("Common");

        }
    }
}
