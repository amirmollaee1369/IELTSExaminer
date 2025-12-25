using MediatR;
using Microsoft.Extensions.Logging;

namespace IELTSExaminer.Application.Features.Exam.EventHandlers;

public class ExamCompletedEventHandler : INotificationHandler<DomainEventNotification<ExamCompletedEvent>>
{
    private readonly ILogger<ExamCompletedEventHandler> _logger;

    public ExamCompletedEventHandler(ILogger<ExamCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DomainEventNotification<ExamCompletedEvent> notification, CancellationToken cancellationToken)
    {
        var domainEvent = notification.DomainEvent;

        _logger.LogInformation("CleanArchitecture Domain Event: {DomainEvent}", domainEvent.GetType().Name);

        return Task.CompletedTask;
    }
}
