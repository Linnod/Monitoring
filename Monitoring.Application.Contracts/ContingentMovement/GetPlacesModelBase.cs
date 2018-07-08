using Monitoring.Application.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Monitoring.Application.Contracts.ContingentMovement
{
    /// <summary>
    /// Базовая модель получения мест
    /// </summary>
    public abstract class GetPlacesModelBase
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
        /// Уровень подготовки
        /// </summary>
        public StudentBackgroundLevelModel BackgroundLevel { get; set; }
    }
}
