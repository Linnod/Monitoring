using Monitoring.Application.Contracts.Common;

namespace Monitoring.Application.Contracts.ContingentMovement
{
    /// <summary>
    /// Модель для перевода студентов
    /// </summary>
    public class MoveStudentsModel
    {
        /// <summary>
        /// Год, с которого будут переводиться студенты
        /// </summary>
        public int FromYear { get; set; }

        /// <summary>
        /// Уровень подготовки, с которого будут переводиться студенты
        /// </summary>
        public StudentBackgroundLevelModel FromBackgroundLevel { get; set; }

        /// <summary>
        /// Идентификатор направления, с которого будут переводиться студенты
        /// </summary>
        public long FromDirectionId { get; set; }

        /// <summary>
        /// Год, на который будут переводиться студенты
        /// </summary>
        public int ToYear { get; set; }

        /// <summary>
        /// Уровень подготовки, на который будут переводиться студенты
        /// </summary>
        public StudentBackgroundLevelModel ToBackgroundLevel { get; set; }

        /// <summary>
        /// Идентификатор направления, на который будут переводиться студенты
        /// </summary>
        public long ToDirectionId { get; set; }

        /// <summary>
        /// Кол-во студентов
        /// </summary>
        public int Quantity { get; set; }
    }
}
