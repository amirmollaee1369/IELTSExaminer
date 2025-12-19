using ConsoleApp1.Enums;
using ConsoleApp1.Models;

namespace ConsoleApp1.Dtos
{
    public class ExamDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public LevelTypeEnum LevelType { get; set; }
        public ExamTypeEnum ExamType { get; set; }
        public DateTime ValidUntilDate { get; set; }
        public TimeOnly LimitTime { get; set; }

    }
}
