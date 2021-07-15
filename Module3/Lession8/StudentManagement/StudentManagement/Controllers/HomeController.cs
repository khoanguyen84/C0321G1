using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Entities;
using StudentManagement.Models.ViewModels;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService studentService;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IDepartmentService departmentService;

        public HomeController(IStudentService studentService, 
                        IWebHostEnvironment webHostEnvironment,
                        IDepartmentService departmentService)
        {
            this.studentService = studentService;
            this.webHostEnvironment = webHostEnvironment;
            this.departmentService = departmentService;
        }
        public IActionResult Index()
        {
            return View("~/Views/Home/Home.cshtml", studentService.GetStudents());
        }

        public IActionResult Detail(int id)
        {
            var student = studentService.GetStudent(id);
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = departmentService.GetDepartments();
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateStudent student)
        {
            if (ModelState.IsValid)
            {
                string filename = "noavatar.jpg";
                if (student.Avatar != null)
                {
                    string folderPath = Path.Combine(webHostEnvironment.ContentRootPath, @"wwwroot\images\");
                    filename = $"{DateTime.Now.ToString("ddMMyyyyhhmmss")}_{student.Avatar.FileName}";
                    string fullpath = Path.Combine(folderPath, filename);
                    using (var file = new FileStream(fullpath, FileMode.Create))
                    {
                        student.Avatar.CopyTo(file);
                    }
                }

                var newStudent = new Student()
                {
                    Avatar = $"/images/{filename}",
                    Dob = student.Dob,
                    Fullname = student.Fullname,
                    Department = departmentService.GetDepartments().FirstOrDefault(d => d.DepartmentId == student.DepartmentId)
                };
                studentService.Create(newStudent);
                return RedirectToAction("Index");
            }
            return View();
        }

        //Attribute Routing
        /*[Route("/Home/Details/{para1}/{para2}")]
        public IActionResult Detail2(string para1, string para2)
        {
            //TempData["Id"] = id;
            //ViewData["Id"] = id;
            ViewBag.Para1 = para1;
            ViewBag.Para2 = para2;
            return View("~/Views/Home/Detail.cshtml");
        }*/
    }
}
