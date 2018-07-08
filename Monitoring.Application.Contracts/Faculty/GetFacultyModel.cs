namespace Monitoring.Application.Contracts.Faculty
{
    /// <summary>
    /// Модель получения факультета
    /// </summary>
    public class GetFacultyModel
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
    }
}
