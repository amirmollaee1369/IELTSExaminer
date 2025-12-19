using ConsoleApp1.Dtos;
using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Services
{
    public class ExamService : IExamService
    {
        public int InsertExam(ExamDto exam)
        {
            throw new NotImplementedException();
        }

        public int InsertExamQuestions(ExamQuestionsDto examDto)
        {
            foreach(var question in examDto.Questions)
            {
                if(question is MultipleChoiceQuestionModel)
                {

                }
            }

            return 1;
        }
    }
}
