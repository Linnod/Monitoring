using Monitoring.Application.Contracts.Faculty;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Monitoring.Application.Interfaces
{
    /// <summary>
    /// Сервис для работы с факультетами
    /// </summary>
    public interface IFacultiesService
    {
        /// <summary>
        /// Добавить факультет
        /// </summary>
        /// <param name="addFacultyModel">Модель для добавления факультета</param>
        /// <returns>Добавленный факультет</returns>
        Task<FacultyModel> AddFacultyAsync(AddFacultyModel addFacultyModel);

        /// <summary>
        /// Удалить факультет
        /// </summary>
        /// <param name="removeFacultyModel">Модель для удаления факультета</param>
        /// <returns>Удалённый факультет</returns>
        Task<FacultyModel> RemoveFacultyAsync(RemoveFacultyModel removeFacultyModel);

        /// <summary>
        /// Получить факультет
        /// </summary>
        /// <param name="getFacultyModel">Модель для получения факультета</param>
        /// <returns>Факультет</returns>
        Task<FacultyModel> GetFacultyAsync(GetFacultyModel getFacultyModel);

        /// <summary>
        /// Пулучить все факультеты
        /// </summary>
        /// <returns>Факультеты</returns>
        Task<ICollection<FacultyModel>> GetFacultiesAsync();
    }
}
