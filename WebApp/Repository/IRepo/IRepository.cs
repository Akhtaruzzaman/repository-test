using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApp.Repository.IRepo
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(long id);
        T Insert(T obj);
        T Update(T obj);
        bool Delete(long id);
        bool Save();
    }
}
