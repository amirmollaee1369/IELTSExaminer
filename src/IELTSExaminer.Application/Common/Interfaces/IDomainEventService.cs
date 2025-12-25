
using IELTSExaminer.Domain.Common;

namespace IELTSExaminer.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
