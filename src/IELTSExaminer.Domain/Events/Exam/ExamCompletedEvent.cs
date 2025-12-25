namespace IELTSExaminer.Domain.Events;

public class ExamCompletedEvent : DomainEvent
{
    public ExamCompletedEvent(ExamModel item)
    {
        Item = item;
    }

    public ExamModel Item { get; }
}
