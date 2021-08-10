using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PNBS.Models.Student;
using PNBS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PNBS.Controllers
{
    public class StudentController : Controller
    {
        private readonly IGradeService gradeService;
        private readonly IStudentService studentService;

        public StudentController(IGradeService gradeService,
                                IStudentService studentService)
        {
            this.gradeService = gradeService;
            this.studentService = studentService;
        }
        // GET: StudentController
        public async Task<ActionResult> Index()
        {
            return View(await studentService.Gets());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public async Task<ActionResult> Create()
        {
            ViewBag.Grades = await gradeService.Gets();
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CreateStudent model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var student = await studentService.Create(model);
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
