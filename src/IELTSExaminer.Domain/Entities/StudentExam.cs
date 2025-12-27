namespace IELTSExaminer.Domain.Entities;

public class StudentExam : BaseModel
{
    public Student Student { get; set; }
    public Exam Exam { get; set; }
    public DateTime ExecuteDate { get; set; }
    public bool IsConfirmed { get; set; }
    public bool Done { get; set; }
}
