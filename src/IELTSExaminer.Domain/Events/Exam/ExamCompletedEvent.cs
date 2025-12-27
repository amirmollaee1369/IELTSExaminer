namespace IELTSExaminer.Domain.Events;

public class ExamCompletedEvent : DomainEvent
{
    public ExamCompletedEvent(Exam item)
    {
        Item = item;
    }

    public Exam Item { get; }
}
