using Monitoring.Application.Contracts.ContingentMovement;

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
        void AddStudents(AddStudentsModel addStudentsModel);

        /// <summary>
        /// Убрать студентов
        /// </summary>
        /// <param name="removeStudentsModel">Модель удаления студентов</param>
        void RemoveStudents(RemoveStudentsModel removeStudentsModel);

        /// <summary>
        /// Перевести студентов
        /// </summary>
        /// <param name="moveStudentsModel">Модель перевода студентов</param>
        void MoveStudents(MoveStudentsModel moveStudentsModel);

        /// <summary>
        /// Получить количество свободных мест
        /// </summary>
        /// <param name="getFreePlacesModel">Модель получения свободных мест</param>
        /// <returns>Кол-во свободных мест</returns>
        PlacesModel GetFreePlaces(GetFreePlacesModel getFreePlacesModel);

        /// <summary>
        /// Получить количество занятых мест
        /// </summary>
        /// <param name="getFreePlacesModel">Модель получения занятых мест</param>
        /// <returns>Кол-во занятых мест</returns>
        PlacesModel GetOccupiedPlaces(GetOccupiedPlacesModel getOccupiedPlacesModel);
    }
}
