using Monitoring.Entities;

namespace Monitoring.Core.Repositories.Interfaces
{
    /// <summary>
    /// Репозиторий для работы с сущностью <see cref="Faculty"/>
    /// </summary>
    public interface IFacultyRepository : IBaseRepository<Faculty, long>
    {
    }
}
