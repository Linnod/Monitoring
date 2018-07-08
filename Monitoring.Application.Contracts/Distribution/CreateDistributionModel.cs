using Monitoring.Application.Contracts.Common;

namespace Monitoring.Application.Contracts.Distribution
{
    /// <summary>
    /// Модель создания распределения
    /// </summary>
    public class CreateDistributionModel
    {
        /// <summary>
        /// Учебный год
        /// </summary>
        public int AcademicYear { get; set; }

        /// <summary>
        /// Идентификатор кафедры
        /// </summary>
        public long DepartmentId { get; set; }

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
