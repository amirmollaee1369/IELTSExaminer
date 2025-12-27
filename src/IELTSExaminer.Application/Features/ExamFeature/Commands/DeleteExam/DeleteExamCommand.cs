using CleanArchitecture.Application.Common.Exceptions;
using IELTSExaminer.Application.Common.Interfaces;
using IELTSExaminer.Domain.Entities;
using IELTSExaminer.Domain.Events;
using MediatR;

namespace IELTSExaminer.Application.Features.ExamFeature.Commands.DeleteExam;

public class DeleteExamCommand : IRequest
{
    public int Id { get; set; }
}

public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteExamCommand>
{
    private readonly IApplicationDbContext _context;

    public DeleteTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteExamCommand request, CancellationToken cancellationToken)
    {
        var entity = await _context.Exams
            .FindAsync(new object[] { request.Id }, cancellationToken);

        if (entity == null)
        {
            throw new NotFoundException(nameof(Domain.Entities.Exam), request.Id);
        }

        _context.Exams.Remove(entity);

        entity.DomainEvents.Add(new ExamDeletedEvent(entity));

        await _context.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}
