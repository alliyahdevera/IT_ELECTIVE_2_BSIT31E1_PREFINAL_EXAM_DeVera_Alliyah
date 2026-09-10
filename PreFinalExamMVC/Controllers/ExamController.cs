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
            ViewBag.TopicTitle = "Relational Data Modeling; Model Binding and Controller Actions";
            return View("PrefinalExam", questions);
        }
        public IActionResult Topic2()
        {
            List<Question> questions = QuestionData.GetTopic2();
            ViewBag.TopicTitle = "Conceptual Data Architecture: Designing ERDs; Razor Syntax and Dynamic Rendering";
            return View("PrefinalExam", questions);
        }
        public IActionResult Topic3()
        {
            List<Question> questions = QuestionData.GetTopic3();
            ViewBag.TopicTitle = "Data Normalization & Structural Integrity; Data Validation and ModelState";
            return View("PrefinalExam", questions);
        }
        public IActionResult Topic4()
        {
            List<Question> questions = QuestionData.GetTopic4();
            ViewBag.TopicTitle = "Introduction to Structured Query Language; In-Memory Data Storage and CRUD Operations";
            return View("PrefinalExam", questions);
        }
    }
}
