using CleanArchitecture.Application.Common.Mappings;

namespace IELTSExaminer.Application.Features.Exam.Queries.GetExamsWithPagination;

public class ExamBriefDto : IMapFrom<Exam>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
