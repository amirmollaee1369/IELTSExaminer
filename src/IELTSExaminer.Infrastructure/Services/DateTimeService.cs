using IELTSExaminer.Application.Common.Interfaces;

namespace IELTSExaminer.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
