using ConsoleApp1.Enums;

namespace ConsoleApp1.Models
{
    public class StudentModel : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public LevelTypeEnum LevelType { get; set; }

    }
}
