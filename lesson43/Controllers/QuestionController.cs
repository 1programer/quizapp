using System.Diagnostics;
using lesson43.Models;
using lesson43.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace lesson43.Controllers
{
    public class QuestionController : Controller
    {
        private static IQuestionsRepository _questionsRepository;
        public QuestionController(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }
        [HttpPost]
        public Question AddQuestion(Question question)
        {
            return _questionsRepository.AddQuestion(question);
        }
        [HttpGet]
        public IActionResult AddQuestions()
        {
            return View("AddQuestion");
        }
        [HttpGet]
        public IActionResult GetQuestions()
        {
            var questions = _questionsRepository.GetAllQuestions();
            return View("QuestionsList", questions);
        }
        [HttpPost]
        public IActionResult DeleteQuestion(int id)
        {
            _questionsRepository.DeleteQuestion(id);
            return RedirectToAction("GetQuestions");
        }
    }
}
