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


        private readonly List<Course> _courses = new List<Course>
        {
            new Course{Id = 1, Code = "CEF444", Title = "Artificial Intelligence & Machine Learning", CreditValue = 4},
            new Course{Id = 2, Code = "CEF450", Title = "Internet Programming & Mobile Programming", CreditValue = 3},
            new Course{Id = 3, Code = "CEF438", Title = "Advanced Database & Administration", CreditValue = 4}
        };


        // GET: Courses
        public ActionResult Index()
        {
            var courseViewModel = new CoursesViewModel
            {
                Courses = _courses
            };

            return View(courseViewModel);
        }

        [Route("Courses/Details/{id:int}")]
        public ActionResult Details(int id)
        {
            Course course = null;
            for (int i = 0; i < _courses.Count; i++)
            {
                if (_courses[i].Id == id)
                {
                    course = _courses[i];
                    break;
                }
            }

            if (course == null)
                return HttpNotFound();

            return View(course);
        }
    }
}