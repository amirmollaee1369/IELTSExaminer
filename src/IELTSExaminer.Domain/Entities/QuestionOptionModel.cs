namespace IELTSExaminer.Domain.Entities;

public class QuestionOptionModel : BaseModel
{
    public string Title { get; set; }
    public bool IsCorrect { get; set; }
}
