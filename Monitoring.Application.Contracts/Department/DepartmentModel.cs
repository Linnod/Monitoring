using Monitoring.Application.Contracts.Faculty;

namespace Monitoring.Application.Contracts.Department
{
    /// <summary>
    /// Кафедра
    /// </summary>
    public class DepartmentModel
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
        public FacultyModel Faculty { get; set; }
    }
}
