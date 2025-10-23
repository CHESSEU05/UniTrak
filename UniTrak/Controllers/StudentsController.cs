using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UniTrak.Models;
using UniTrak.ViewModels;

namespace UniTrak.Controllers
{
    public class StudentsController : Controller
    {
        private ApplicationDbContext _context;

        public StudentsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var students = _context.Students.Include(s => s.MembershipType).OrderBy(s => s.Name).ToList();
            var studentsViewModel = new StudentsViewModel
            {
                Students = students
            };
            
            return View(studentsViewModel);
        }

        [Route("Students/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            var student = _context.Students.Include(s => s.MembershipType).SingleOrDefault(s => s.Id == id);

            if (student == null)
                return HttpNotFound();

            return View(student);
        }
    }
}