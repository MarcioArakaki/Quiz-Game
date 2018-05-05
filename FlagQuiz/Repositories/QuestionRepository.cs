using System.Collections.Generic;
using System.Linq;
using FlagQuiz.Models;

namespace FlagQuiz.Repositories
{
    public class QuestionRepository
    {
        private readonly List<Question> _questions;
        private readonly FlagRepository _flagRepository;

        public QuestionRepository(FlagRepository flagRepository)
        {
            _flagRepository = flagRepository;
            _questions = InitializeQuestion();
        }

        /// <summary>
        /// Initialize the question repository to simulate a Database
        /// </summary>
        private List<Question> InitializeQuestion()
        {
            return new List<Question>()
            {
                new Question()
                {
                    IdQuestion = 1,
                    Options = new List<Flag>(){ _flagRepository.Get(1),_flagRepository.Get(4),_flagRepository.Get(5),_flagRepository.Get(7)},
                    Flag = _flagRepository.Get(5),
                },
                new Question()
                {
                    IdQuestion = 2,
                    Options = new List<Flag>(){ _flagRepository.Get(6),_flagRepository.Get(1),_flagRepository.Get(11),_flagRepository.Get(10)},
                    Flag = _flagRepository.Get(1),
                },
                new Question()
                {
                    IdQuestion = 3,
                    Options = new List<Flag>(){ _flagRepository.Get(9),_flagRepository.Get(8),_flagRepository.Get(1),_flagRepository.Get(4)},
                    Flag = _flagRepository.Get(4),
                },
                new Question()
                {
                    IdQuestion = 4,
                    Options = new List<Flag>(){ _flagRepository.Get(7),_flagRepository.Get(3),_flagRepository.Get(1),_flagRepository.Get(11)},
                    Flag = _flagRepository.Get(11),
                },
                new Question()
                {
                    IdQuestion = 5,
                    Options = new List<Flag>(){ _flagRepository.Get(10),_flagRepository.Get(2),_flagRepository.Get(4),_flagRepository.Get(9)},
                    Flag = _flagRepository.Get(9),
                },
                new Question()
                {
                    IdQuestion = 6,
                    Options = new List<Flag>(){ _flagRepository.Get(5),_flagRepository.Get(7),_flagRepository.Get(8),_flagRepository.Get(6)},
                    Flag = _flagRepository.Get(6),
                },
                new Question()
                {
                    IdQuestion = 7,
                    Options = new List<Flag>(){ _flagRepository.Get(2),_flagRepository.Get(3),_flagRepository.Get(5),_flagRepository.Get(8)},
                    Flag = _flagRepository.Get(2),
                },
                new Question()
                {
                    IdQuestion = 8,
                    Options = new List<Flag>(){ _flagRepository.Get(7),_flagRepository.Get(5),_flagRepository.Get(6),_flagRepository.Get(9)},
                    Flag = _flagRepository.Get(7),
                },
                new Question()
                {
                    IdQuestion = 9,
                    Options = new List<Flag>(){ _flagRepository.Get(2),_flagRepository.Get(8),_flagRepository.Get(11),_flagRepository.Get(1)},
                    Flag = _flagRepository.Get(8),
                },
                new Question()
                {
                    IdQuestion = 10,
                    Options = new List<Flag>(){ _flagRepository.Get(11),_flagRepository.Get(6),_flagRepository.Get(3),_flagRepository.Get(8)},
                    Flag = _flagRepository.Get(3),
                },
            };
        }

        public Question Get(int IdQuestion)
        {
            return _questions.FirstOrDefault(x => x.IdQuestion == IdQuestion);
        }

        public List<Question> GetAll()
        {
            return _questions;
        }
    }
}