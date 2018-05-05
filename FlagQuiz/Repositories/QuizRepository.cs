using System.Collections.Generic;
using System.Linq;
using FlagQuiz.Models;

namespace FlagQuiz.Repositories
{
    public class QuizRepository
    {
        private readonly QuestionRepository _questionRepository;
        private readonly List<Quiz> _quiz;

        public QuizRepository()
        {
            var flagRepository = new FlagRepository();
            _questionRepository = new QuestionRepository(flagRepository);
            _quiz = InitializeQuiz();
        }

        /// <summary>
        /// Initialize the quiz repository to simulate a Database
        /// </summary>
        public List<Quiz> InitializeQuiz()
        {
            return new List<Quiz>() { new Quiz
            {
                IdQuiz = 1,
                TotalQuestions = 10,
                Questions = _questionRepository.GetAll().Take(10).ToList(), //TODO: Make this random
            }};
        }

        public Quiz Get(int idQuiz)
        {
           return  _quiz.FirstOrDefault(x => x.IdQuiz == idQuiz);
        }
    }
}