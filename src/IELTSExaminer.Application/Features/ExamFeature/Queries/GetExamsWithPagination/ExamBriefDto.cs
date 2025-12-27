using CleanArchitecture.Application.Common.Mappings;
using IELTSExaminer.Domain.Entities;

namespace IELTSExaminer.Application.Features.ExamFeature.Queries.GetExamsWithPagination;

public class ExamBriefDto : IMapFrom<Exam>
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
