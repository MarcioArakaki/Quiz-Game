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
        private readonly FlagRepository _flagRepository;
        private readonly Quiz _game;

        public FlagQuizController()
        {
            var quizRepository = new QuizRepository();
            _flagRepository = new FlagRepository();
            _game = quizRepository.Get(1);
        }

        public ActionResult Flags(int indexQuestion)
        {
            var question = _game.Questions[indexQuestion - 1];

            return View("Quiz", new QuizViewModel() { TotalQuestions = _game.TotalQuestions, Question = question, Index = indexQuestion });
        }

        public ActionResult CheckAnswer(int indexQuestion, int idAnswer)
        {
            var question = _game.Questions[indexQuestion - 1];
            var correct = question.Flag.IdFlag == idAnswer;

            SaveGameHistory(indexQuestion, idAnswer, question.Flag, correct);
            return Json(new { correct });
        }
        public void SaveGameHistory(int indexQuestion, int idAnswer, Flag correctAnswer, bool correct)
        {
            var QuizResult = (TempData["QuizResult"] as List<QuestionResult>) ?? new List<QuestionResult>();
            QuizResult.Add(
                new QuestionResult()
                {
                    Index = indexQuestion,
                    Answer = _flagRepository.Get(idAnswer),
                    CorrectAnswer = correctAnswer,
                    Correct = correct,
                });
            TempData["QuizResult"] = QuizResult;
        }

        public ActionResult Result()
        {
            if (!(TempData["QuizResult"] is List<QuestionResult> quizLog))
            {
                //When Tempdata is not Valid returns to initial page 
                //TODO: Improve error handling
                return Flags(1);
            }
            decimal totalpoints = 0;
            var flagsResults = new List<QuestionResult>();
            foreach (var result in quizLog)
            {
                var points = result.CorrectAnswer.Multiplier * 10;
                if (result.CorrectAnswer.IdFlag == result.Answer.IdFlag)
                {
                    totalpoints += points;
                }

                flagsResults.Add(new QuestionResult()
                {
                    Index = result.Index,
                    Answer = result.Answer,
                    CorrectAnswer = result.CorrectAnswer,
                    Correct = result.Correct,
                    Points = points,
                });
            }

            return View("Result", new QuizResultViewModel()
            {
                Points = totalpoints,
                Results = flagsResults
            });
        }
    }
}