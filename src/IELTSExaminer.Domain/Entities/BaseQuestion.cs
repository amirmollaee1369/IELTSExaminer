namespace IELTSExaminer.Domain.Entities;

public class BaseQuestion : BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
}
