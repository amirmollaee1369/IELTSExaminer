namespace IELTSExaminer.Domain.Entities;

public class MultipleChoiceQuestion : BaseQuestion
{
    public List<QuestionOption> Options { get; set; }
}
