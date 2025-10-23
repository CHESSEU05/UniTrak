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
    public class CoursesController : Controller
    {

        private ApplicationDbContext _context;
        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Courses
        public ActionResult Index()
        {
            var courses = _context.Courses.Include(c => c.CategoryType).OrderBy(c => c.Title).ToList();
            var courseViewModel = new CoursesViewModel
            {
                Courses = courses
            };
            
            return View(courseViewModel);
        }


        [Route("Courses/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            var course = _context.Courses.Include(c => c.CategoryType).SingleOrDefault(c => c.Id == id);

            if (course == null)
                return HttpNotFound();

            return View(course);
        }
    }
}