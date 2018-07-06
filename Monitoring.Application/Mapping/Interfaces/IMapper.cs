namespace Monitoring.Application.Mapping.Interfaces
{
    /// <summary>
    /// Маппер
    /// </summary>
    public interface IMapper
    {
        /// <summary>
        /// Смапить одну сущность в другую
        /// </summary>
        /// <typeparam name="TIn">Тип сущности на входе</typeparam>
        /// <typeparam name="TOut">Тип сущности на выходе</typeparam>
        /// <param name="source">Сущность на входе</param>
        /// <returns>Сущность на выходе</returns>
        TOut Map<TIn, TOut>(TIn source);
    }
}
