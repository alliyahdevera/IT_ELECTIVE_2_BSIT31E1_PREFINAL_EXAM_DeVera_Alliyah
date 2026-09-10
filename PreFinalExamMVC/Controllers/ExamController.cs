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
        public IActionResult Topic2()
        {
            List<Question> questions = QuestionData.GetTopic2();
            ViewBag.TopicTitle = "Relationships & Navigation Properties";
            return View("PrefinalExam", questions);
        }
        public IActionResult Topic3()
        {
            List<Question> questions = QuestionData.GetTopic3();
            ViewBag.TopicTitle = "ViewModels & Queries";
            return View("PrefinalExam", questions);
        }
    }
}
