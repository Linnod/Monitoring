using Microsoft.EntityFrameworkCore;
using Monitoring.Entities;

namespace Monitoring.DataLayer
{
    /// <summary>
    /// Контекст данных приложения
    /// </summary>
    public partial class ApplicationContext : DbContext
    {
        /// <summary>
        /// Контекст данных приложения
        /// </summary>
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        /// <summary>
        /// Кафедры
        /// </summary>
        public virtual DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Направления
        /// </summary>
        public virtual DbSet<Direction> Directions { get; set; }

        /// <summary>
        /// Распределения
        /// </summary>
        public virtual DbSet<Distribution> Distributions { get; set; }
         
        /// <summary>
        /// Факультеты
        /// </summary>
        public virtual DbSet<Faculty> Faculties { get; set; }
    }
}
