using Monitoring.Entities;

namespace Monitoring.Core.Repositories.Interfaces
{
    /// <summary>
    /// Репозиторий для работы с сущностью <see cref="Direction"/>
    /// </summary>
    public interface IDirectionRepository : IBaseRepository<Direction, long>
    {
    }
}
