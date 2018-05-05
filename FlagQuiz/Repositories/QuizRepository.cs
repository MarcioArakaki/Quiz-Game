using System.Collections.Generic;
using System.Linq;
using FlagQuiz.Models;

namespace FlagQuiz.Repositories
{
    public class QuizRepository
    {
        private readonly QuestionRepository _questionRepository;
        private readonly FlagRepository _flagRepository;
        private readonly List<Quiz> _quiz;

        public QuizRepository()
        {
            _flagRepository = new FlagRepository();
            _questionRepository = new QuestionRepository(_flagRepository);
        }


        public List<Quiz> InitializeQuiz()
        {
            return new List<Quiz>() { new Quiz
            {
                IdQuiz = 1, //Fixed here but it would be auto generated with a DB
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