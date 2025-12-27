namespace IELTSExaminer.Domain.Entities;

public class QuestionOption : BaseModel
{
    public string Title { get; set; }
    public bool IsCorrect { get; set; }
}
