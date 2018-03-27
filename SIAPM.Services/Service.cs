using Sensing.Data.Infrastructure;
using Sensing.Entities.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SIAPM.Services
{
    public abstract class Service<TEntity> where TEntity : class, IObjectState
    {
        protected readonly SIAPMContext _sIAPMContext;
        public Service(SIAPMContext context)
        {
            _sIAPMContext = context;
        }
        public TEntity Find(params object[] keyValues) { return _sIAPMContext.Find<TEntity>(keyValues); }
        public IQueryable<TEntity> SelectQuery(string query, params object[] parameters) { return null; }
        public void Insert(TEntity entity)
        {
            try
            {
                _sIAPMContext.Add(entity);
                //int records = await _sIAPMContext.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            
        }
        public void InsertRange(IEnumerable<TEntity> entities)
        {
            _sIAPMContext.AddRange(entities);
            
        }
        public void InsertOrUpdateGraph(TEntity entity) { }
        public void InsertGraphRange(IEnumerable<TEntity> entities) { }
        public void Update(TEntity entity) { _sIAPMContext.Update(entity); }
        public void Delete(object id) { }
        public void Delete(TEntity entity) { _sIAPMContext.Remove(entity); }
        public virtual IQueryFluent<TEntity> Query()
        {
            return null;
        }
        public async Task SaveChangesAsync()
        {
            int records = await _sIAPMContext.SaveChangesAsync();
        }
        public IQueryFluent<TEntity> Query(IQueryObject<TEntity> queryObject) { return null; }
        public virtual IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> query)
        {
            
            return null;
        }
        public Task<TEntity> FindAsync(params object[] keyValues) { return null; }
        public Task<TEntity> FindAsync(CancellationToken cancellationToken, params object[] keyValues) { return null; }
        public Task<bool> DeleteAsync(params object[] keyValues) { return null; }
        public Task<bool> DeleteAsync(CancellationToken cancellationToken, params object[] keyValues) { return null; }
        public IQueryable<TEntity> Queryable() { return null; }
    }
}
