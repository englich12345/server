using CoreApp.Application.ViewModels.Functions;
using CoreApp.Persistence.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Application.Service
{
    public interface IFunctionService
    {
        Task<IQueryable<FunctionViewModel>> GetAll();

        Task<IQueryable<FunctionViewModel>> GetByPermission(Guid Id);

    }

    public class FunctionService : IFunctionService
    {
        private readonly IRepository<FunctionViewModel> _repository;

        public FunctionService(IRepository<FunctionViewModel> repository)
        {
            _repository = repository;
        }

        public async Task<IQueryable<FunctionViewModel>> GetAll()
        {
            return _repository.GetAll();
        }

        public async Task<IQueryable<FunctionViewModel>> GetByPermission(Guid Id)
        {
            return _repository.Fetch(x => x.Id == Id);
        }
    }
}
