using CommonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApp.Repository.IRepo
{
    public interface IRepository<T> : IDisposable
               where T : Entity
    {
        Task<bool> Add(T entity);
        Task<bool> AddMany(List<T> entity);
        Task<bool> Update(T entity);

        /// <summary>
        /// This method for permanent delation of those row that
        /// are not used in any transaction
        /// </summary>
        /// <param name="id"></param>
        Task<bool> Delete(long id);
        Task<int> Count();
        Task<int> Count(Expression<Func<T, bool>> expression);
        Task<T> Get(long id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        /// <summary>
        /// Get any by expression first or default
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        Task<T> GetAny(Expression<Func<T, bool>> expression);
    }
}
