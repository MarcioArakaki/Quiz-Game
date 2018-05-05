using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagQuiz.Models
{
    public class Question
    {
        public int IdQuestion { get; set; }
        public List<Flag> Options { get; set; }
        public Flag Flag { get; set; }
    }
}