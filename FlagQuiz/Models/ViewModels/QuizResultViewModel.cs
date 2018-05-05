using System.Collections.Generic;

namespace FlagQuiz.Models.ViewModels
{
    public class QuizResultViewModel
    {
        public decimal Points { get; set; }
        public List<QuestionResult> Results { get; set; }
    }
}