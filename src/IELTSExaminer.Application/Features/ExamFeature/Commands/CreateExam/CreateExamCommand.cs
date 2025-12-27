using IELTSExaminer.Application.Common.Interfaces;
using IELTSExaminer.Domain.Entities;
using IELTSExaminer.Domain.Events;
using MediatR;

namespace IELTSExaminer.Application.Features.ExamFeature.Commands.CreateExam;

public class CreateExamCommand : IRequest<int>
{
    public int ListId { get; set; }

    public string? Title { get; set; }
}

public class CreateTodoItemCommandHandler : IRequestHandler<CreateExamCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreateTodoItemCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreateExamCommand request, CancellationToken cancellationToken)
    {
        var entity = new Domain.Entities.Exam
        {
           
        };

        entity.DomainEvents.Add(new ExamCreatedEvent(entity));

        _context.Exams.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
