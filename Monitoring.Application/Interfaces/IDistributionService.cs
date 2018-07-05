using Monitoring.Application.Contracts.Distribution;

namespace Monitoring.Application.Interfaces
{
    /// <summary>
    /// Сервис для работы с распределениями
    /// </summary>
    public interface IDistributionService
    {
        /// <summary>
        /// Получить распределение
        /// </summary>
        /// <param name="model">Модель получения распределения</param>
        /// <returns>Распределение</returns>
        DistributionModel GetDistribution(GetDistributionModel model);

        /// <summary>
        /// Обновить распределение
        /// </summary>
        /// <param name="updateDistributionModel">Модель обновления распределения</param>
        /// <returns>Обновлённое распределение</returns>
        DistributionModel UpdateDistribution(UpdateDistributionModel updateDistributionModel);

        /// <summary>
        /// Создать распределение
        /// </summary>
        /// <param name="createDistributionModel">Модель создания распределения</param>
        /// <returns>Созданное распределение</returns>
        DistributionModel CreateDistribution(CreateDistributionModel createDistributionModel);
    }
}
