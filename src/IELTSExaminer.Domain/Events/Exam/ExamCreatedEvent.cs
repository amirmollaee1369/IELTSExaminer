namespace IELTSExaminer.Domain.Events;

public class ExamCreatedEvent : DomainEvent
{
    public ExamCreatedEvent(Exam item)
    {
        Item = item;
    }

    public Exam Item { get; }
}
