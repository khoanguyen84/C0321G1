using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentService studentService;

        public HomeController(IStudentService studentService)
        {
            this.studentService = studentService;
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
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            studentService.Create(student);
            return RedirectToAction("Index");
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
