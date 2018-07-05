using Monitoring.Entities.Interfaces;
using System.Collections.Generic;

namespace Monitoring.Entities
{
    /// <summary>
    /// Кафедра
    /// </summary>
    public class Department : IEntityWithId<long>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Факультет
        /// </summary>
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Направление
        /// </summary>
        public ICollection<Direction> Directions { get; set; } = new List<Direction>();
    }
}
