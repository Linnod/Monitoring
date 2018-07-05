using Monitoring.Entities.Interfaces;
using System.Collections.Generic;

namespace Monitoring.Entities
{
    /// <summary>
    /// Факультет
    /// </summary>
    public class Faculty : IEntityWithId<long>
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
        /// Кафедры
        /// </summary>
        public ICollection<Department> Departments { get; set; } = new HashSet<Department>();
    }
}
