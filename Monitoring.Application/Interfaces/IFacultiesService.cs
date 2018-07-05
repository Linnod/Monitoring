using Monitoring.Application.Contracts.Faculty;
using System.Collections.Generic;

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
        FacultyModel AddFaculty(AddFacultyModel addFacultyModel);

        /// <summary>
        /// Удалить факультет
        /// </summary>
        /// <param name="removeFacultyModel">Модель для удаления факультета</param>
        /// <returns>Удалённый факультет</returns>
        FacultyModel RemoveFaculty(RemoveFacultyModel removeFacultyModel);

        /// <summary>
        /// Получить факультет
        /// </summary>
        /// <param name="getFacultyModel">Модель для получения факультета</param>
        /// <returns>Факультет</returns>
        FacultyModel GetFaculty(GetFacultyModel getFacultyModel);

        /// <summary>
        /// Пулучить все факультеты
        /// </summary>
        /// <returns>Факультеты</returns>
        ICollection<FacultyModel> GetFaculties();
    }
}
