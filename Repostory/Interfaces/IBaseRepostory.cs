using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repostory
{
   public interface IBaseRepostory<T>where T:class
    {
        Task<IEnumerable<T>> GetAll(string[] includes = null, int? take = null, int? skip = null,
            Expression<Func<T, object>> orderBy = null, string OrderByDirection = OrderBy.Ascending);
        Task<T> GetByID(int id);
        Task<IEnumerable<T>> FindAll(Expression<Func<T, bool>> match, string[] includes = null, int? take = null, int? skip = null ,
            Expression<Func<T ,object>>orderBy =null,string OrderByDirection=OrderBy.Ascending);

        Task<T> Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        void Attach(T entity);
        void AttachRange(IEnumerable<T> entities);
        Task<int> CountAsync(Expression<Func<T, bool>> criteria);



    }
}
