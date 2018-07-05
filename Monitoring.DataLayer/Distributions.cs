using Microsoft.EntityFrameworkCore;
using Monitoring.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace Monitoring.DataLayer
{
    /// <summary>
    /// Работа с <see cref="Distribution"/>
    /// </summary>
    public partial class ApplicationContext
    {
        /// <summary>
        /// Найти распределение по году, направлению и уровню подготовки
        /// </summary>
        /// <param name="year">Учебный год</param>
        /// <param name="directionId">Направление</param>
        /// <param name="backgroundLevel">Уровень подготовки</param>
        /// <returns>Распределение</returns>
        public virtual async Task<Distribution> FindByYearDirectionBackgroundLevelAsync(int year, long directionId, StudentBackgroundLevel backgroundLevel)
        {
            var result = await Distributions
                .SingleOrDefaultAsync
                (
                    d =>
                        d.AcademicYear == year
                        && d.Department.Directions.Any(dir => dir.Id == directionId)
                        && d.BackgroundLevel == backgroundLevel
                );

            return result;
        }
    }
}
