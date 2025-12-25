using IELTSExaminer.Application.Common.Interfaces;
using IELTSExaminer.Domain.Entities;
using MediatR;

namespace IELTSExaminer.Application.Features.Exam.Commands.CreateExam;

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
        var entity = new ExamModel
        {
           
        };

        entity.DomainEvents.Add(new ExamModelCreatedEvent(entity));

        _context.ExamModels.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}
