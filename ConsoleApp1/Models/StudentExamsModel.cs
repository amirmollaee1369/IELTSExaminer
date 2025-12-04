namespace ConsoleApp1.Models
{
    public class StudentExamsModel : BaseModel
    {
        public StudentModel Student { get; set; }
        public ExamModel Exam { get; set; }
        public DateTime ExecuteDate { get; set; }
        public bool IsConfirmed { get; set; }
        public bool Done { get; set; }
    }
}
