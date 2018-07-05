namespace Monitoring.Application.Contracts.Distribution
{
    /// <summary>
    /// Модель обновления распределения
    /// </summary>
    public class UpdateDistributionModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Актуальное количество студентов
        /// </summary>
        public int ActualStudentCount { get; set; }
    }
}
