using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagQuiz.Models
{
    public class QuestionResult
    {
        public int Index { get; set; }
        public Flag CorrectAnswer { get; set; }
        public Flag Answer { get; set; }
        public bool Correct { get; set; }
        public decimal Points { get; set; }

    }
}