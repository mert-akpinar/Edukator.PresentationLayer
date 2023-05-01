using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading;

namespace Edukator.PresentationLayer.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.totalCategory = context.Categories.Count();
            ViewBag.totalCourse = context.Courses.Count();
            ViewBag.totalPrice = context.Courses.Sum(x=>x.Price);
            ViewBag.getAlgoritmaProgramlamaCoursePrice = context.Courses.Where(x=>x.Name == "Algoritma ve Programlama").Select(y => y.Price).FirstOrDefault();
            
            ViewBag.avgReview = context.Courses.Average(x=>x.Review);
            ViewBag.getOver30Price = context.Courses.Where(x => x.Price > 30).Count();
            ViewBag.lastCoursePrice = context.Courses.Where(x => x.CourseID == 6).Select(y => y.Price).FirstOrDefault();
            ViewBag.getTitleCourseID2 = context.Courses.Where(x => x.CourseID == 2).Select(y => y.Name).FirstOrDefault();

            ViewBag.softwareCourseCount = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault())).Count();
            ViewBag.maxCoursePrice = context.Courses.Max(x=>x.Price);
            ViewBag.minCoursePrice = context.Courses.Min(y=>y.Price);
            ViewBag.mostExpensive = context.Courses.Where(x => x.Price == (context.Courses.Max(y => y.Price))).Select(z => z.Name).FirstOrDefault();
            
            ViewBag.lastCoursePriceTitle = context.Courses.Where(x=>x.CourseID == (context.Courses.Max(y => y.CourseID))).Select(z => z.Name).FirstOrDefault();
            ViewBag.avgPriceForSoftwareCourse = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
            ViewBag.last3CourseTotalPrice = context.Courses.OrderByDescending(x => x.CourseID).Take(3).Sum(y => y.Price);
            ViewBag.getCourseCategorySoftwareAndReviewMore9Score = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault()) && x.Review >= 9).Select(w => w.Name).FirstOrDefault();




            return View();
        }
    }
}
