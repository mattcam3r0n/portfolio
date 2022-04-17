using MediatR;

namespace Portfolio.SharedKernel;

public abstract class BaseDomainEvent : INotification
{
  public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
}
