using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using My_assigment.Models;

namespace My_assigment.Controllers
{
    public class schLessonController : Controller
    {
        


        [HttpGet] //Default kan uteslutas
        public ActionResult createBooking()
        {
            return View();
        }
        public IActionResult showLesson()
        {
            using (LessonContext database = new LessonContext())
            {
                var lessons = database.lessonBooking.ToList();
                return View(lessons);
            }
        }




        [HttpPost]
        public IActionResult Add(LessonBooking newBooking)
        {
            using (LessonContext database = new LessonContext())
            {
                database.lessonBooking.Add(newBooking);
                database.SaveChanges();
            }
            //Gå till sidan som visar listan över filmer
            return RedirectToAction("showLesson");
        }

    }
}
