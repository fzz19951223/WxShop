using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.IService
{
    public interface IBaseService<TEntity> where TEntity:class,new()
    {
        bool Add(TEntity tEntity);
        bool Remove(TEntity tEntity);
        bool Modify(TEntity tEntity);
        TEntity SelectEntity(Func<TEntity, bool> wherelambda);
        //查询多个
        IEnumerable<TEntity> GetEntities(Func<TEntity, bool> wherelambda);
        //分页 pageindex第几页,pagesize一页多少条数据,
        //Expression <Func<TEntity, Ttype>> 和Func<TEntity,bool> wherelambda

        IEnumerable<TEntity> GetEntitiesByPage<Ttype>(int pageindex, int pagesize, bool isAsc,
           Expression<Func<TEntity, Ttype>> orderlambda, Expression<Func<TEntity, bool>> wherelambda);
    }
}
