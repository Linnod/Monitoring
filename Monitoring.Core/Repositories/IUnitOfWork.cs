using Monitoring.Core.Repositories.Interfaces;

namespace Monitoring.Core.Repositories
{
    /// <summary>
    /// Единица работы
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Кафедры
        /// </summary>
        IDepartmentRepository Departments { get; }

        /// <summary>
        /// Направления
        /// </summary>
        IDirectionRepository Directions { get; }

        /// <summary>
        /// Распределения
        /// </summary>
        IDistributionRepository Distributions { get; }

        /// <summary>
        /// Факультеты
        /// </summary>
        IFacultyRepository Faculties { get; }

        /// <summary>
        /// Сохранить изменения
        /// </summary>
        void SaveChanges();
    }
}
