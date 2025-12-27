using CleanArchitecture.Application.Common.Exceptions;
using IELTSExaminer.Application.Common.Interfaces;
using MediatR;

namespace IELTSExaminer.Application.Features.ExamFeature.Commands.UpdateExam;

public class UpdateExamCommand : IRequest
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}

public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateExamCommand>
{
    private readonly IApplicationDbContext _context;

    public UpdateTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateExamCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Exams
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Exam), request.Id);
        }

        //entity.Title = request.Title;
        //entity.Done = request.Done;

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
