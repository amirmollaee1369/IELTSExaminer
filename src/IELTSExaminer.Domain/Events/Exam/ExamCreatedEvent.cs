namespace IELTSExaminer.Domain.Events;

public class ExamCreatedEvent : DomainEvent
{
    public ExamCreatedEvent(ExamModel item)
    {
        Item = item;
    }

    public ExamModel Item { get; }
}
