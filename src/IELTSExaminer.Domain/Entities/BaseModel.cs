
namespace IELTSExaminer.Domain.Entities;

public class BaseModel : AuditableEntity, IHasDomainEvent
{
    public int Id { get; set; }
    public List<DomainEvent> DomainEvents { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
