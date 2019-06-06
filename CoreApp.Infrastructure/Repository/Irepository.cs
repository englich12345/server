using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Persistence.Repository
{
    public interface IRepository<T>
    {
        AppDbContext AppDbContext();
        #region Get

        IQueryable<T> GetAll();

        IQueryable<T> Fetch(Expression<Func<T, bool>> expression);

        Task<T> FetchFirstAsync(Expression<Func<T, bool>> expression);


        Task<T> GetByIdAsync(Guid? id);

        Task<RespondModel> ExcuteSqlAsync(string sql);

        #endregion

        #region Insert

        Task<RespondModel> InsertAsync(T entity);

        Task<RespondModel> InsertAsync(IEnumerable<T> entities);

        #endregion

        #region Update

        Task<RespondModel> UpdateAsync(T entity);

        #endregion

        #region Delete

        Task<RespondModel> DeleteAsync(T entity);

        Task<RespondModel> DeleteAsync(IEnumerable<T> entities);

        Task<RespondModel> DeleteAsync(Guid id);

        Task<RespondModel> DeleteAsync(IEnumerable<Guid> ids);

        #endregion
    }
}
