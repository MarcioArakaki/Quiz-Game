using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlagQuiz.Models
{
    public class Flag
    {
        public int IdFlag { get; set; }
        public string Country { get; set; }
        public int Multiplier { get; set; }
        public string Image { get; set; }
    }
}