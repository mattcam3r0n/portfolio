using Ardalis.Specification;

namespace Portfolio.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
