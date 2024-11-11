using System.Linq.Expressions;


namespace HarvardUniversity.API.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAsync(Dictionary<string, Object> args);   //For Tests Only!!!
        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null,
                                             Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                             string includeProperties = "",
                                             Expression<Func<TEntity, TEntity>>? select = null);
        Task<(List<TEntity> Entities, int TotalCount)> GetAllWithTotalCountAsync(Dictionary<string, Object> args);   //For Tests Only!!!
        Task<(List<TEntity> Entities, int TotalCount)> GetAllWithTotalCountAsync(int skipValue = 0, int takeValue = int.MaxValue,
                                               Expression<Func<TEntity, bool>>? filter = null,
                                               Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                               string includeProperties = "",
                                               Expression<Func<TEntity, TEntity>>? select = null);
        Task<TEntity> GetByIDAsync(int? id);
        Task CreateAsync(TEntity entity);
        Task DeleteAsync(int? id);
        Task UpdateAsync(TEntity entity);
    }
}

