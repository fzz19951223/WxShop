using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Shop.IService;
using Shop.IRepository;
using System.Linq.Expressions;

namespace Shop.Service
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        private IBaseRepository<TEntity> _baseRepository;
        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public bool Add(TEntity tEntity)
        {
            _baseRepository.Insert(tEntity);
            return _baseRepository.savaChanges();
        }

        public bool Modify(TEntity tEntity)
        {
            _baseRepository.Update(tEntity);
            return _baseRepository.savaChanges();
        }

        public bool Remove(TEntity tEntity)
        {
            _baseRepository.Delete(tEntity);
            return _baseRepository.savaChanges();
        }

        public IEnumerable<TEntity> GetEntities(Func<TEntity, bool> wherelambda)
        {
            return _baseRepository.SelectEntities(wherelambda);
        }

        public IEnumerable<TEntity> GetEntitiesByPage<Ttype>(int pageindex, int pagesize, bool isAsc, Expression<Func<TEntity, Ttype>> orderlambda, Expression<Func<TEntity, bool>> wherelambda)
        {
            return _baseRepository.SelectEntitiesByPage(pageindex, pagesize, isAsc, orderlambda, wherelambda);
        }
        
        public TEntity SelectEntity(Func<TEntity, bool> wherelambda)
        {
            return _baseRepository.SelectEntity(wherelambda);
        }
    }
}
