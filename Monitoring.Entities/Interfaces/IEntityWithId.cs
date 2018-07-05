namespace Monitoring.Entities.Interfaces
{
    public interface IEntityWithId<TId>
    {
        TId Id { get; }
    }
}
