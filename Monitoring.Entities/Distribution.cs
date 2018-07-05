using Monitoring.Entities.Interfaces;

namespace Monitoring.Entities
{
    /// <summary>
    /// Распределение
    /// </summary>
    public class Distribution : IEntityWithId<long>
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
        public Department Department { get; set; }

        /// <summary>
        /// Уровень подготовки
        /// </summary>
        public StudentBackgroundLevel BackgroundLevel { get; set; }

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
