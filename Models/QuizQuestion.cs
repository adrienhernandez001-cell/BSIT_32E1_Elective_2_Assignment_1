namespace BSIT_32E1_Elective_2_Assignment_1.Models
{
    public class QuizQuestion
    {
        public int Number { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public Dictionary<string, string> Options { get; set; } = new();
        public string CorrectOption { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }

    public class AssignmentViewModel
    {
        public string StudentName { get; set; } = string.Empty;
        public List<QuizQuestion> Questions { get; set; } = new();
    }
}