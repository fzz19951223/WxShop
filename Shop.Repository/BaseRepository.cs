using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Model;
using Shop.IRepository;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Shop.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        //从工厂中获取上下文对象
        private readonly Model1 wx = DbContextFactory.CreateDbContext();
        private DbSet<TEntity> _dbSet;
        public BaseRepository()
        {
            this._dbSet = wx.Set<TEntity>();
        }
        public void Delete(TEntity tEntity)
        {
            _dbSet.Attach(tEntity);
            _dbSet.Remove(tEntity);
        }

        public void Insert(TEntity tEntity)
        {
            _dbSet.Add(tEntity);
        }
        //查询多个实体
        public IEnumerable<TEntity> SelectEntities(Func<TEntity, bool> wherelambda)
        {
            return _dbSet.Where(wherelambda);
        }
        //分页
        public IEnumerable<TEntity> SelectEntitiesByPage<Ttype>(int pageindex, int pagesize, bool isAsc, Expression<Func<TEntity, Ttype>> orderlambda, Expression<Func<TEntity, bool>> wherelambda)
        {
            var result = _dbSet.Where(wherelambda);
            result = isAsc ? result.OrderBy(orderlambda) : result.OrderByDescending(orderlambda);
            var offset = (pageindex - 1) * pagesize;
            result = result.Skip(offset).Take(pagesize);
            return result;
        }
        //单个实体
        public TEntity SelectEntity(Func<TEntity, bool> wherelambda)
        {
            return _dbSet.FirstOrDefault(wherelambda);
        }
            
        public void Update(TEntity tEntity)
        {
            _dbSet.Attach(tEntity);
            wx.Entry(tEntity).State = EntityState.Modified;
        }

        public bool savaChanges()
        {
            return wx.SaveChanges() > 0;
        }
    }
}
