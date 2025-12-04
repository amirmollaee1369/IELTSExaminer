using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Services
{
    public class ExamFakeService : IExamService
    {
        public void InsertExam()
        {
            Console.WriteLine("Fake");
        }
    }
}
