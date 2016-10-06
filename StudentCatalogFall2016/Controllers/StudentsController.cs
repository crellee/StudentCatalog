using StudentCatalogFall2016.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentCatalogFall2016.Models;

namespace StudentCatalogFall2016.Controllers
{
    public class StudentsController : Controller
    {
        //[AllowAnonymous]
        //[Authorize]
        //[Authorize(Roles = "Adminstrator")]

        StudentRepository studentRepository = new StudentRepository();
        private Models.ApplicationDbContext db = new Models.ApplicationDbContext();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                studentRepository.InsertOrUpdate(student);
                return View("Thanks");
            }
            return View();

        }

        [Authorize(Roles = "Adminstrator")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StudentModel student = db.Students.Find(id);
            return View(student);
        }
        [Authorize(Roles = "Adminstrator")]
        [HttpPost]
        public ActionResult Edit(StudentModel student)
        {
            if(ModelState.IsValid)
            {
                studentRepository.InsertOrUpdate(student);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            studentRepository.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            StudentModel student = studentRepository.findId(id);
            return View(student);
        }
        public ActionResult Index(string searchString)
        {
            var students = studentRepository.Search(searchString);
            return View(students);
        }
    }
}