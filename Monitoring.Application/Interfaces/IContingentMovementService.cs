using Monitoring.Application.Contracts.ContingentMovement;
using System.Threading.Tasks;

namespace Monitoring.Application.Interfaces
{
    /// <summary>
    /// Сервис движения контингента
    /// </summary>
    public interface IContingentMovementService
    {
        /// <summary>
        /// Добавить студентов
        /// </summary>
        /// <param name="addStudentsModel">Модель добавления студентов</param>
        Task AddStudentsAsync(AddStudentsModel addStudentsModel);

        /// <summary>
        /// Убрать студентов
        /// </summary>
        /// <param name="removeStudentsModel">Модель удаления студентов</param>
        Task RemoveStudentsAsync(RemoveStudentsModel removeStudentsModel);

        /// <summary>
        /// Перевести студентов
        /// </summary>
        /// <param name="moveStudentsModel">Модель перевода студентов</param>
        Task MoveStudentsAsync(MoveStudentsModel moveStudentsModel);

        /// <summary>
        /// Получить количество свободных мест
        /// </summary>
        /// <param name="getFreePlacesModel">Модель получения свободных мест</param>
        /// <returns>Кол-во свободных мест</returns>
        Task<PlacesModel> GetFreePlacesAsync(GetFreePlacesModel getFreePlacesModel);

        /// <summary>
        /// Получить количество занятых мест
        /// </summary>
        /// <param name="getFreePlacesModel">Модель получения занятых мест</param>
        /// <returns>Кол-во занятых мест</returns>
        Task<PlacesModel> GetOccupiedPlacesAsync(GetOccupiedPlacesModel getOccupiedPlacesModel);
    }
}
