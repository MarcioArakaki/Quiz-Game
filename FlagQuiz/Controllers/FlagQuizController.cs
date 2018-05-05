using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlagQuiz.Models;
using FlagQuiz.Models.ViewModels;
using FlagQuiz.Repositories;

namespace FlagQuiz.Controllers
{
    public class FlagQuizController : Controller
    {
        private readonly QuizRepository _quizRepository;
        private Quiz game;

        public FlagQuizController()
        {
            _quizRepository = new QuizRepository();
            game = _quizRepository.Get(1);
        }
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult GetQuestion(int indexQuestion)
        {
           var question =  game.Questions[indexQuestion];

           return View("Quiz",new QuizViewModel(){TotalQuestions = game.TotalQuestions, Question = question, Index = indexQuestion});
        }
    }
}