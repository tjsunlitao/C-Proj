using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWeb.Models;

namespace HelloWeb.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student{ID=1, Name="Student_1"},
                new Student{ID=2, Name="Student_2"},
                new Student{ID=3, Name="Student_3"},
                new Student{ID=4, Name="Student_4"},
                new Student{ID=5, Name="Student_5"},
            };
            return View(students);
        }
    }
}