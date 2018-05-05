using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagQuiz.Models
{
    public class Quiz
    {
        public int IdQuiz { get; set; }
        public List<Question> Questions { get; set; }
        public int TotalQuestions { get; set; }
    }
}