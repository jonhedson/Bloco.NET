using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CachingCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace CachingCore.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Index()
        {
            List<Student> listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
               new Student() { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
            };
            return View(listStudents);
        }

        public ViewResult Details(int Id)
        {
            var studentDetails = new Student() { StudentId = Id, Name = "James", Branch = "CSE", Section = "A", Gender = "Male" };
            return View(studentDetails);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Create(Student s)
        {
            return View();
        }

    }
}
