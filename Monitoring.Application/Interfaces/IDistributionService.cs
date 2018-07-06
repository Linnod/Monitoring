using Monitoring.Application.Contracts.Distribution;
using System.Threading.Tasks;

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
        Task<DistributionModel> GetDistributionAsync(GetDistributionModel model);

        /// <summary>
        /// Обновить распределение
        /// </summary>
        /// <param name="updateDistributionModel">Модель обновления распределения</param>
        /// <returns>Обновлённое распределение</returns>
        Task<DistributionModel> UpdateDistributionAsync(UpdateDistributionModel updateDistributionModel);

        /// <summary>
        /// Создать распределение
        /// </summary>
        /// <param name="createDistributionModel">Модель создания распределения</param>
        /// <returns>Созданное распределение</returns>
        Task<DistributionModel> CreateDistributionAsync(CreateDistributionModel createDistributionModel);

        /// <summary>
        /// Удалить распределение
        /// </summary>
        /// <param name="deleteDistributionModel">Модель удаления распределения</param>
        /// <returns>Удалённые распределение</returns>
        Task<DistributionModel> DeleteDistributionAsync(DeleteDistributionModel deleteDistributionModel);
    }
}
