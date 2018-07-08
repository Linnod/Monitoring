namespace Monitoring.Application.Contracts.Department
{
    /// <summary>
    /// Модель получения кафедры
    /// </summary>
    public class GetDepartmentModel
    {
        /// <summary>
        /// Идентификатор кафедры
        /// </summary>
        public long? Id { get; set; }
        
        /// <summary>
        /// Название кафедры
        /// </summary>
        public string Name { get; set; }
    }
}
