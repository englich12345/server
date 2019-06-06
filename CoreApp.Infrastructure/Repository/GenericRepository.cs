using CoreApp.Data.Entities.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Persistence.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : BaseClass
    {

        public readonly AppDbContext _appDbContext;

        public AppDbContext AppDbContext
        {
            get { return AppDbContext; }
        }

        public GenericRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        #region Get

        public virtual IQueryable<T> GetAll()
        {
            return _appDbContext.Set<T>().OrderBy(x => x.Id);
        }

        //public bool CheckExist(string id)
        //{
        //    var user = _appDbContext.AppUsers.FirstOrDefaultAsync(x => x.Email == id);

        //}

        public IQueryable<T> Fetch(Expression<Func<T, bool>> expression)
        {
            return GetAll().Where(expression);
        }

        public async Task<T> FetchFirstAsync(Expression<Func<T, bool>> expression)
        {
            return await GetAll().FirstOrDefaultAsync(expression);
        }

        public async Task<T> GetByIdAsync(Guid? id)
        {
            return await _appDbContext.Set<T>().FirstOrDefaultAsync(i => i.Id == id);
        }

        /// <summary> Excute sql
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>

        public async Task<RespondModel> ExcuteSqlAsync(string sql)
        {
            var respond = new RespondModel();
            _appDbContext.Database.ExecuteSqlCommand(sql);
            await _appDbContext.SaveChangesAsync();
            respond.StatusCode = System.Net.HttpStatusCode.OK;
            return respond;
        }

        #endregion

        #region Insert

        public async Task<RespondModel> InsertAsync(T entity)
        {
            var response = new RespondModel();
            var dbSet = _appDbContext.Set<T>().Add(entity);
            await _appDbContext.SaveChangesAsync();
            response.data = entity;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        public async Task<RespondModel> InsertAsync(IEnumerable<T> entities)
        {
            var response = new RespondModel();
            var dbSet = _appDbContext.Set<T>();
            foreach(var entity in entities)
            {
                dbSet.Add(entity);
            }
            await _appDbContext.SaveChangesAsync();
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        #endregion

        #region Update

        public async Task<RespondModel> UpdateAsync(T entity)
        {
            var response = new RespondModel();
            var dbSet = _appDbContext.Set<T>().Update(entity);
            await _appDbContext.SaveChangesAsync();
            response.data = entity;
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        #endregion

        #region Delete

        public async Task<RespondModel> DeleteAsync(T entity)
        {
            var response = new RespondModel();
            if(entity == null)
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }
            var dbSet = _appDbContext.Set<T>().Remove(entity);
            await _appDbContext.SaveChangesAsync();
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        public async Task<RespondModel> DeleteAsync(IEnumerable<T> entities)
        {
            var response = new RespondModel();
            if (entities == null || entities.Any())
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }
            var dbSet = _appDbContext.Set<T>();
            foreach(var entity in entities)
            {
                dbSet.Remove(entity);
            }
            await _appDbContext.SaveChangesAsync();
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        public async Task<RespondModel> DeleteAsync(Guid id)
        {
            var response = new RespondModel();
            if(GetByIdAsync(id) == null)
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
                return response;
            }
            var entity = await GetByIdAsync(id);
            var dbSet = _appDbContext.Set<T>();
            dbSet.Remove(entity);
            await _appDbContext.SaveChangesAsync();
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;

        }

        public async Task<RespondModel> DeleteAsync(IEnumerable<Guid> ids)
        {
            var response = new RespondModel();
            if(ids == null || ids.Any())
            {
                response.StatusCode = System.Net.HttpStatusCode.NotFound;
            }
            var dbSet = _appDbContext.Set<T>();
            dbSet.RemoveRange(Fetch(x => ids.Contains(x.Id)));
            await _appDbContext.SaveChangesAsync();
            response.StatusCode = System.Net.HttpStatusCode.OK;
            return response;
        }

        public IQueryable<T> Fetch(Expression<Func<T, object>> includeProperties)
        {
            throw new NotImplementedException();
        }

        AppDbContext IRepository<T>.AppDbContext()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
