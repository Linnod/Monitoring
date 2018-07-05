namespace Monitoring.Application.Contracts.ContingentMovement
{
    /// <summary>
    /// Базовая модель изменения кол-ва мест студентов
    /// </summary>
    public abstract class ChangeStudentsQuantityModelBase
    {
        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Уровень подготовки
        /// </summary>
        public StudentBackgroundLevelModel BackgroundLevel { get; set; }

        /// <summary>
        /// Идентификатор направления
        /// </summary>
        public long DirectionId { get; set; }

        /// <summary>
        /// Кол-во студентов
        /// </summary>
        public int Quantity { get; set; }
    }
}
