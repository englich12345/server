using CoreApp.Application.Utilities;
using CoreApp.Application.ViewModels.PageViewModel;
using CoreApp.Application.ViewModels.Products;
using CoreApp.Data.Entities;
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
    public interface IProductCategoryService
    {
        PagedList<ProductCategoryViewModel> GetList(UserRequestListViewModel userRequestListViewModel);

        Task<ProductCategoryViewModel> GetByIdAsync(Guid id);

        IQueryable<NameProductCategoryViewModel> GetNameProductCategoryAsync();

        Task<RespondModel> AddProductAsync(AddProductCategoryViewModel addProductCategoryViewModel);

        Task<RespondModel> DeleteAsync(Guid id);

        Task<RespondModel> UpdateAsync(Guid id, UpdateProductCategoryViewModel updateProductCategoryViewModel);

        //IQueryable<ProductCategoryViewModel> GetAll();

        //IQueryable<ProductCategoryViewModel> GetAll(RequestProductViewModel requestProductViewModel);
        
        //IQueryable<ProductCategoryViewModel> GetHomeCategories(int top);
    }

    public class ProductCategoryService : IProductCategoryService
    {
        public readonly IRepository<ProductCategory> _productCategoryRepository;

        public ProductCategoryService(IRepository<ProductCategory> productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task<RespondModel> AddProductAsync(AddProductCategoryViewModel addProductCategoryViewModel)
        {
            var addUser = AutoMapper.Mapper.Map<ProductCategory>(addProductCategoryViewModel);
            return await _productCategoryRepository.InsertAsync(addUser);
        }

        public async Task<RespondModel> DeleteAsync(Guid id)
        {
            return await _productCategoryRepository.DeleteAsync(id);
        }

        public async Task<ProductCategoryViewModel> GetByIdAsync(Guid id)
        {
            var categories = await _productCategoryRepository.GetByIdAsync(id);
            return new ProductCategoryViewModel(categories); 
        }

        private List<string> GetAllPropertyNameOfProductCategoryViewModel()
        {
            var productCategoryViewModel = new ProductCategoryViewModel();
            var type = productCategoryViewModel.GetType();

            return ReflectionUtilities.GetAllPropertyNamesOfType(type);
        }

        public PagedList<ProductCategoryViewModel> GetList(UserRequestListViewModel userRequestListViewModel)
        {
            var query = _productCategoryRepository.GetAll().Where(x => ((string.IsNullOrEmpty(userRequestListViewModel.keyword)) || (x.Name.Contains(userRequestListViewModel.keyword))))
                        .OrderByDescending(x => x.DateCreated)
                        .Select(x => new ProductCategoryViewModel(x)).ToList();
            var productCategoryViewModelProperties = GetAllPropertyNameOfProductCategoryViewModel();
            var requestPropertyName = !string.IsNullOrEmpty(userRequestListViewModel.SortName) ? userRequestListViewModel.SortName.ToLower() : string.Empty;
            string matchedPropertyName = string.Empty;

            foreach (var productCategoryViewModelProperty in productCategoryViewModelProperties)
            {
                var lowerTypeViewModelProperty = productCategoryViewModelProperty.ToLower();
                if (lowerTypeViewModelProperty.Equals(requestPropertyName))
                {
                    matchedPropertyName = productCategoryViewModelProperty;
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
            return new PagedList<ProductCategoryViewModel>(query, userRequestListViewModel.offset ?? CommonConstants.Config.DEFAULT_SKIP, userRequestListViewModel.limit ?? CommonConstants.Config.DEFAULT_TAKE);
        }

        public async Task<RespondModel> UpdateAsync(Guid id, UpdateProductCategoryViewModel updateProductCategoryViewModel)
        {
            var productCategory = await _productCategoryRepository.GetByIdAsync(id);
            if (productCategory == null)
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't find product category"
                };
            else
            {
                var updateProductCategory = updateProductCategoryViewModel.UpdateProductCategory(productCategory);
                return await _productCategoryRepository.UpdateAsync(updateProductCategory);
            }
        }

        public IQueryable<NameProductCategoryViewModel> GetNameProductCategoryAsync()
        {
            return _productCategoryRepository.GetAll().Select(x => new NameProductCategoryViewModel(x));
        }

        //public IQueryable<ProductCategoryViewModel> GetAll()
        //{
        //    return _productCategoryRepository.GetAll().Select(x=>new ProductCategoryViewModel(x));
        //}

        //public IQueryable<ProductCategoryViewModel> GetHomeCategories(int top)
        //{
        //    return _productCategoryRepository.Fetch(x => x.HomeFlag == true).Include(x => x.Products);
        //}

        //public IQueryable<ProductCategoryViewModel> GetAll(RequestProductViewModel requestProductViewModel)
        //{
        //    return _productCategoryRepository.Fetch(x => x.Name.Contains(requestProductViewModel.name)).Select(x=>new ProductCategoryViewModel(x));
        //}
    }
}
