using IELTSExaminer.Application.Common.Models;
using IELTSExaminer.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace IELTSExaminer.Application.Features.ExamFeature.EventHandlers;

public class ExamCreatedEventHandler : INotificationHandler<DomainEventNotification<ExamCreatedEvent>>
{
    private readonly ILogger<ExamCreatedEventHandler> _logger;

    public ExamCreatedEventHandler(ILogger<ExamCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(DomainEventNotification<ExamCreatedEvent> notification, CancellationToken cancellationToken)
    {
        var domainEvent = notification.DomainEvent;

        _logger.LogInformation("CleanArchitecture Domain Event: {DomainEvent}", domainEvent.GetType().Name);

        return Task.CompletedTask;
    }
}
