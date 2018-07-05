namespace Monitoring.Application.Contracts.Direction
{
    /// <summary>
    /// Направление
    /// </summary>
    public class DirectionModel
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
        /// Код
        /// </summary>
        public string Code { get; set; }
    }
}
