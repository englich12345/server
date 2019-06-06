using CoreApp.Application.Utilities;
using CoreApp.Application.ViewModels.PageViewModel;
using CoreApp.Application.ViewModels.Products;
using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using CoreApp.Persistence.Constants;
using CoreApp.Persistence.Repository;
using CoreApp.Utilities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Application.Service
{
    public interface IProductService
    {
        IList<ProductViewModel> GetAll();

        PagedList<ProductViewModel> GetList(UserRequestListViewModel userRequestListViewModel);

        Task<RespondModel> AddAsync(AddProductViewModel addProductViewModel);

        Task<Product> GetByIdAsync(Guid id);

        Task<RespondModel> UpdateAsync(Guid id, UpdateProductViewModel updateProductViewModel);

        Task<RespondModel> DeleteAsync(Guid id);
    }

    public class ProductService : IProductService
    {
        public readonly IRepository<Product> _repository;
        
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }
        
        public IList<ProductViewModel> GetAll()
        {
            var products = _repository.GetAll().Include(x => x.ProductCategory).Select(x => new ProductViewModel(x)).ToList();
            return products;
        }


        public async Task<Product> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        private List<string> GetAllPropertyNameOfProductViewModel()
        {
            var productViewModel = new ProductViewModel();
            var type = productViewModel.GetType();

            return ReflectionUtilities.GetAllPropertyNamesOfType(type);
        }

        public PagedList<ProductViewModel> GetList(UserRequestListViewModel userRequestListViewModel)
        {
            var query = _repository.GetAll().Include(x=>x.ProductCategory).Where(x => (x.Status == Status.Active) && ((string.IsNullOrEmpty(userRequestListViewModel.keyword)) || (x.Name.Contains(userRequestListViewModel.keyword))))
                .OrderByDescending(x => x.DateCreated)
                .Select(x => new ProductViewModel(x)).ToList();
            var productViewModelProperties = GetAllPropertyNameOfProductViewModel();
            var requestPropertyName = !string.IsNullOrEmpty(userRequestListViewModel.SortName) ? userRequestListViewModel.SortName.ToLower() : string.Empty;
            string matchedPropertyName = string.Empty;

            foreach (var productViewModelProperty in productViewModelProperties)
            {
                var lowerTypeViewModelProperty = productViewModelProperty.ToLower();
                if (lowerTypeViewModelProperty.Equals(requestPropertyName))
                {
                    matchedPropertyName = productViewModelProperty;
                    break;
                }
            }

            if (string.IsNullOrEmpty(matchedPropertyName))
            {
                matchedPropertyName = "Name";
            }

            var type = typeof(ProductViewModel);
            var sortProperty = type.GetProperty(matchedPropertyName);
            query = userRequestListViewModel.IsDesc ? query.OrderByDescending(x => sortProperty.GetValue(x, null)).ToList() : query.OrderBy(x => sortProperty.GetValue(x, null)).ToList();
            return new PagedList<ProductViewModel>(query, userRequestListViewModel.offset ?? CommonConstants.Config.DEFAULT_SKIP, userRequestListViewModel.limit ?? CommonConstants.Config.DEFAULT_TAKE);
        }

        public async Task<RespondModel> AddAsync(AddProductViewModel addProductViewModel)
        {
            var product = AutoMapper.Mapper.Map<Product>(addProductViewModel);
            return await _repository.InsertAsync(product);
        }

        public async Task<RespondModel> UpdateAsync(Guid id, UpdateProductViewModel updateProductViewModel)
        {
            var product = await _repository.FetchFirstAsync(x => x.Id == id);
            if (product == null)
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't find user"
                };
            else
            {
                var productUpdate = updateProductViewModel.UpdateProduct(product);
                return await _repository.UpdateAsync(productUpdate);
            }
        }

        public async Task<RespondModel> DeleteAsync(Guid id)
        {
            var product = await _repository.FetchFirstAsync(x => x.Id == id);
            if (product == null)
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't find user"
                };
            else
            {
                return await _repository.DeleteAsync(id);
            }
        }
    }
}
