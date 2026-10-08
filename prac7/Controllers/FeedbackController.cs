using System.Web.Mvc;
using prac7.Models;

namespace prac7.Controllers
{
    public class FeedbackController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Submit(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Feedback submitted successfully!";
            }

            return View("Index", feedback);
        }
    }
}