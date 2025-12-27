namespace IELTSExaminer.Domain.Events;

public class ExamDeletedEvent : DomainEvent
{
    public ExamDeletedEvent(Exam item)
    {
        Item = item;
    }

    public Exam Item { get; }
}
