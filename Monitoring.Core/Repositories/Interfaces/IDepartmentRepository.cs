using Monitoring.Entities;

namespace Monitoring.Core.Repositories.Interfaces
{
    /// <summary>
    /// Репозиторий для работы с сущностью <see cref="Department"/>
    /// </summary>
    public interface IDepartmentRepository : IBaseRepository<Department, long>
    {

    }
}
