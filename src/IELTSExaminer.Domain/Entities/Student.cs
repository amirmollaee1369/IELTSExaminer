using IELTSExaminer.Domain.Enums;

namespace IELTSExaminer.Domain.Entities;
public class Student : BaseModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public LevelTypeEnum LevelType { get; set; }

}
