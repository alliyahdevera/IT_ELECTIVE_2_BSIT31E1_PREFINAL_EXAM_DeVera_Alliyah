using Microsoft.AspNetCore.Mvc;
using PreFinalExamMVC.Models;
using System.Collections.Generic;

namespace PreFinalExamMVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Topic1()
        {
            List<Question> questions = QuestionData.GetTopic1();
            ViewBag.TopicTitle = "EF Core & Database Basics";
            return View("PrefinalExam", questions);
        }
    }
}
