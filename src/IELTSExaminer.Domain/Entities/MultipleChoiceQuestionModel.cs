namespace IELTSExaminer.Domain.Entities;

public class MultipleChoiceQuestionModel : BaseQuestionModel
{
    public List<QuestionOptionModel> Options { get; set; }
}
