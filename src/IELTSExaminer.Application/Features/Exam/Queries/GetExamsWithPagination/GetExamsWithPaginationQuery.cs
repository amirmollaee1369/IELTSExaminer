using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.Application.Common.Mappings;
using CleanArchitecture.Application.Common.Models;
using IELTSExaminer.Application.Common.Interfaces;
using MediatR;

namespace IELTSExaminer.Application.Features.Exam.Queries.GetExamsWithPagination;

public class GetExamsWithPaginationQuery : IRequest<PaginatedList<ExamBriefDto>>
{
    public int ListId { get; set; }
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetTodoItemsWithPaginationQueryHandler : IRequestHandler<GetExamsWithPaginationQuery, PaginatedList<ExamBriefDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetTodoItemsWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<ExamBriefDto>> Handle(GetExamsWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await _context.ExamModels
            .Where(x => x.ListId == request.ListId)
            .OrderBy(x => x.Title)
            .ProjectTo<ExamBriefDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
