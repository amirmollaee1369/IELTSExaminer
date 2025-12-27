using IELTSExaminer.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace IELTSExaminer.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Exam> Exams { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
