using IELTSExaminer.Domain.Enums;

namespace IELTSExaminer.Domain.Entities;
public class ExamModel : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public LevelTypeEnum LevelType { get; set; }
    public ExamTypeEnum ExamType { get; set; }
    public DateTime ValidUntilDate { get; set; }
    public TimeOnly LimitTime { get; set; }

    public List<BaseQuestionModel> Questions { get; set; }
}
