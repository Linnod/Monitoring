namespace Monitoring.Application.Contracts.Department
{
    /// <summary>
    /// Модель создания кафедры
    /// </summary>
    public class CreateDepartmentModel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Факультет
        /// </summary>
        public long FacultyId { get; set; }

        /// <summary>
        /// Направление
        /// </summary>
        public long DirectionId { get; set; }
    }
}
