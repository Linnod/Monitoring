using Monitoring.Application.Contracts.Common;
using Monitoring.Application.Contracts.Department;

namespace Monitoring.Application.Contracts.Distribution
{
    /// <summary>
    /// Распределение
    /// </summary>
    public class DistributionModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Учебный год
        /// </summary>
        public int AcademicYear { get; set; }

        /// <summary>
        /// Кафедра
        /// </summary>
        public DepartmentModel Department { get; set; }

        /// <summary>
        /// Уровень подготовки
        /// </summary>
        public StudentBackgroundLevelModel BackgroundLevel { get; set; }

        /// <summary>
        /// Актуальное количество студентов
        /// </summary>
        public int ActualStudentCount { get; set; }

        /// <summary>
        /// Ожидаемое количество студентов
        /// </summary>
        public int ExpectedStudentCount { get; set; }
    }
}
