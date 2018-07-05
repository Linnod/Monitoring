using Monitoring.Entities.Interfaces;
using System.Collections.Generic;

namespace Monitoring.Core.Repositories.Interfaces
{
    /// <summary>
    /// Базовый репозиторий
    /// </summary>
    /// <typeparam name="TEntity">Тип сущности, с которой работает репозиторий</typeparam>
    /// <typeparam name="TId">Тип идентификатора сущности</typeparam>
    public interface IBaseRepository<TEntity, TId> 
        where TEntity : IEntityWithId<TId>
    {
        /// <summary>
        /// Получить сущность по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <returns>Сущность</returns>
        TEntity Get(TId id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns>Сущности</returns>
        ICollection<TEntity> GetAll();

        /// <summary>
        /// Создать сущность
        /// </summary>
        /// <param name="entity">Сущность</param>
        /// <returns>Созданная сущность</returns>
        TEntity Create(TEntity entity);

        /// <summary>
        /// Удалить сущность
        /// </summary>
        /// <param name="entity">Сущность</param>
        /// <returns>Удалённая сущность</returns>
        TEntity Delete(TEntity entity);

        /// <summary>
        /// Удалить всё
        /// </summary>
        /// <returns>Удалённые сущности</returns>
        ICollection<TEntity> DeleteAll();

        /// <summary>
        /// Обновить сущность
        /// </summary>
        /// <param name="entity">Сущность</param>
        /// <returns>Обновлённая сушность</returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Обновить коллекцию сущностей
        /// </summary>
        /// <param name="entities">Коллекция сущностей</param>
        /// <returns>Коллеция обновлённых сущностей</returns>
        ICollection<TEntity> Update(ICollection<TEntity> entities);
    }
}
