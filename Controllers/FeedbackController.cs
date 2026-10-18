using System.Collections.Generic;
using System.Web.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        private static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult GiveFeedback()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GiveFeedback(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                feedbackList.Add(feedback);

                return RedirectToAction("ViewFeedback");
            }

            return View(feedback);
        }

        public ActionResult ViewFeedback()
        {
            return View(feedbackList);
        }
    }
}