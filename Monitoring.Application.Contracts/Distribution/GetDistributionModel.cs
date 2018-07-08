using Monitoring.Application.Contracts.Common;

namespace Monitoring.Application.Contracts.Distribution
{
    /// <summary>
    /// Модель для получения распределения
    /// </summary>
    public class GetDistributionModel
    {
        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Идентификатор направления
        /// </summary>
        public long DirectionId { get; set; }

        /// <summary>
        /// Уровень подготовки студента
        /// </summary>
        public StudentBackgroundLevelModel Level { get; set; }
    }
}
