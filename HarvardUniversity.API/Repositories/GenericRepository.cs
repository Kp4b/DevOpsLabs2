using HarvardUniversity.API.Contracts;
using HarvardUniversity.DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Z.EntityFramework.Plus;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;


#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
namespace HarvardUniversity.API.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly HarvardUniversityContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(HarvardUniversityContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        // Use for tests only!
        public async Task<IEnumerable<TEntity>> GetAsync(Dictionary<string, Object> args)
        {
            var include = args.TryGetValue("include", out object? i) ? (string)i : "";
            var orderBy = args.TryGetValue("orderBy", out object? ord)
                        ? (Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>)ord : null;
            var filter = args.TryGetValue("filter", out object? f)
                       ? (Expression<Func<TEntity, bool>>)f : null;
            var select = args.TryGetValue("select", out object? sel)
                       ? (Expression<Func<TEntity, TEntity>>)sel : null;

            return await GetAsync(filter: filter,
                                  orderBy: orderBy,
                                  includeProperties: include,
                                  select: select);
        }

        public async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>>? filter = null,
                                                         Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                         string includeProperties = "",
                                                         Expression<Func<TEntity, TEntity>>? select = null)
        {
            try
            {
                return await GetEntityListQuery(filter, select, includeProperties, orderBy).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }

        // Use for tests only!
        public async Task<(List<TEntity> Entities, int TotalCount)> GetAllWithTotalCountAsync(Dictionary<string, Object> args)
        {
            var skip = args.TryGetValue("skip", out object? s) ? (int)s : 0;
            var take = args.TryGetValue("take", out object? t) ? (int)t : int.MaxValue;
            var include = args.TryGetValue("include", out object? i) ? (string)i : "";
            var orderBy = args.TryGetValue("orderBy", out object? ord)
                        ? (Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>)ord : null;
            var filter = args.TryGetValue("filter", out object? f)
                       ? (Expression<Func<TEntity, bool>>)f : null;
            var select = args.TryGetValue("select", out object? sel)
                       ? (Expression<Func<TEntity, TEntity>>)sel : null;

            return await GetAllWithTotalCountAsync(skipValue: skip, takeValue: take,
                                                   filter: filter,
                                                   orderBy: orderBy,
                                                   includeProperties: include,
                                                   select: select);
        }

        public async Task<(List<TEntity> Entities, int TotalCount)> GetAllWithTotalCountAsync(
                                                                    int skipValue = 0, int takeValue = int.MaxValue,
                                                                    Expression<Func<TEntity, bool>>? filter = null,
                                                                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                                                    string includeProperties = "",
                                                                    Expression<Func<TEntity, TEntity>>? select = null)
        {
            if (skipValue < 0 || takeValue <= 0) throw new ArgumentOutOfRangeException();

            var futureEntitiesList = GetEntityListQuery(filter, select, includeProperties, orderBy)
                                     .Skip(skipValue)
                                     .Take(takeValue)
                                     .Future();
            var futureCount = GetEntityCountFutureQuery(filter);

            try
            {
                return (await futureEntitiesList.ToListAsync(), await futureCount.ValueAsync());
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message, ex.InnerException);
            }
        }

        public async Task<TEntity> GetByIDAsync(int? id)
        {
            if (id == null) throw new ArgumentNullException();
#pragma warning disable CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
            return await _dbSet.FindAsync(id);
#pragma warning restore CS8603 // Возможно, возврат ссылки, допускающей значение NULL.
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(int? id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);
            await DeleteAsync(entityToDelete);
        }

        public Task UpdateAsync(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
            return Task.CompletedTask;
        }

        private Task DeleteAsync(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
            return Task.CompletedTask;
        }

        private IQueryable<TEntity> GetEntityListQuery(Expression<Func<TEntity, bool>>? filter,
                                                       Expression<Func<TEntity, TEntity>>? select,
                                                       string includeProperties,
                                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy)
        {
            IQueryable<TEntity> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperties);
            }

            if (orderBy != null)
            {
                if (select == null)
                    return orderBy(query);

                return orderBy(query).Select(select);
            }
            else
            {
                if (select == null)
                    return query;

                return query.Select(select);
            }
        }

        private QueryFutureValue<int> GetEntityCountFutureQuery(Expression<Func<TEntity, bool>>? filter = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return query.DeferredCount().FutureValue();
        }
    }
}

