using ConsoleApp1.Models;
namespace ConsoleApp1.Dtos
{
    public class ExamQuestionsDto
    {
        public ExamModel Exam { get; set; }
        public List<BaseQuestionModel> Questions { get; set; }
    }
}
