namespace Monitoring.Application.Contracts.ContingentMovement
{
    /// <summary>
    /// Модель с количеством свободных/занятых мест
    /// </summary>
    public class PlacesModel
    {
        /// <summary>
        /// Кол-во мест
        /// </summary>
        public int Quantity { get; set; }
    }
}
