using ServicesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnityTest.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService courseService;
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        // GET: Course
        public ActionResult Index()
        {
            return View(this.courseService.GetCourseByID(1));
        }
    }
}