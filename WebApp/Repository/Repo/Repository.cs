using CommonLibrary;
using Microsoft.EntityFrameworkCore;
using Repository.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApp.Repository.IRepo;

namespace WebApp.Repository.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private WebAppContext _db = null;
        private DbSet<T> table = null;
        public Repository(DbContextOptions<WebAppContext> dbContextOptions)
        {
            this._db = new WebAppContext(dbContextOptions);
            table = _db.Set<T>();
        }

        public Repository(WebAppContext _context)
        {
            this._db = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            try
            {
                return table.ToList();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T GetById(long id)
        {
            try
            {
                return table.Find(id);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T Insert(T obj)
        {
            try
            {
                table.Add(obj);
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T Update(T obj)
        {
            try
            {
                table.Attach(obj);
                _db.Entry(obj).State = EntityState.Modified;
                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool Delete(long id)
        {
            try
            {
                T existing = table.Find(id);
                table.Remove(existing);
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public bool Save()
        {
            try
            {
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
