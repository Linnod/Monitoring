namespace Monitoring.Application.Contracts.Department
{
    /// <summary>
    /// Модель обновления кафедры
    /// </summary>
    public class UpdateDepartmentModel
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
        public long FacultyId { get; set; }

        /// <summary>
        /// Направление
        /// </summary>
        public long DirectionId { get; set; }
    }
}
