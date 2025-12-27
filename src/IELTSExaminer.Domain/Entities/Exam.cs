namespace IELTSExaminer.Domain.Entities;
public class Exam : BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public LevelTypeEnum LevelType { get; set; }
    public ExamTypeEnum ExamType { get; set; }
    public DateTime ValidUntilDate { get; set; }
    public TimeOnly LimitTime { get; set; }

    public List<BaseQuestion> Questions { get; set; }
}
