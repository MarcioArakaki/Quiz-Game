namespace FlagQuiz.Models.ViewModels
{
    public class QuizViewModel
    {
        public int TotalQuestions { get; set; }
        public int Index { get; set; }
        public Question Question { get; set; }
    }
}