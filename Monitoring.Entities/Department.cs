using Monitoring.Entities.Interfaces;

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
        public Direction Direction { get; set; }
    }
}
