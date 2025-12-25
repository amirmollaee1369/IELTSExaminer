namespace IELTSExaminer.Domain.Events;

public class ExamDeletedEvent : DomainEvent
{
    public ExamDeletedEvent(ExamModel item)
    {
        Item = item;
    }

    public ExamModel Item { get; }
}
