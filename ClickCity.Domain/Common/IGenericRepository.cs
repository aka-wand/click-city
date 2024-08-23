namespace ClickCity.Domain.Common
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        Task CreateAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}