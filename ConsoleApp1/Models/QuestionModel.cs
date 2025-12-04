using ConsoleApp1.Enums;

namespace ConsoleApp1.Models
{
    public class QuestionModel : BaseModel
    {
        public string Title { get; set; }
        public int QuestionType { get; set; }
        public string Description { get; set; }
        public List<QuestionOptionModel> Options { get; set; }
    }
}
