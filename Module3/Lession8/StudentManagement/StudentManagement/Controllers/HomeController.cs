using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> Students = new List<Student>() {
                new Student()
                {
                    Id = 1,
                    Fullname = "Buu Nguyen",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "images/avatar10.jpg"
                },
                new Student()
                {
                    Id = 2,
                    Fullname = "Nam Thu",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "images/avatar10.jpg"
                },
                new Student()
                {
                    Id = 3,
                    Fullname = "Nam Ngoc",
                    Dob = DateTime.Parse("2000-10-10"),
                    Avatar = "images/avatar10.jpg"
                }
            };

            return View("~/Views/Home/Home.cshtml", Students);
        }
    }
}
