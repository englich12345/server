using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Application.Service;
using CoreApp.Application.ViewModels.PageViewModel;
using CoreApp.Application.ViewModels.Products;
using CoreApp.Data.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Areas.Admin.Controllers
{
    [Route("admin/categories")]
    [EnableCors("CorsPolicy")]
    public class ProductCategoryController : BaseController
    {
        IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetList(UserRequestListViewModel userRequestListViewModel)
        {
            var model = _productCategoryService.GetList(userRequestListViewModel);
            return Ok(model);
        }

        [HttpGet]
        [Route("namecategory")]
        public IActionResult GetNameProductCategory()
        {
            var result = _productCategoryService.GetNameProductCategoryAsync();
            return Ok(result);
        }

        [HttpGet]
        [Route("list/{id}")]
        public async Task<IActionResult> getById(Guid id)
        {
            var productcategory = await _productCategoryService.GetByIdAsync(id);
            return Ok(productcategory);
        }

        [HttpPost]
        [Route("list")]
        public async Task<IActionResult> addProductCategory([FromBody] AddProductCategoryViewModel addProductCategoryViewModel)
        {
            var respond = await _productCategoryService.AddProductAsync(addProductCategoryViewModel);
            if (respond.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(respond.data);
            }
            else
            {
                return BadRequest(new { Message = respond.Message });
            }

        }

        [HttpPut]
        [Route("list/{id}")]
        public async Task<IActionResult> updateProductCategory(Guid id, [FromBody] UpdateProductCategoryViewModel updateProductCategoryViewModel)
        {
            var response = await _productCategoryService.UpdateAsync(id, updateProductCategoryViewModel);
            return Ok(response);
        }

        [HttpDelete]
        [Route("list/{id}")]
        public async Task<IActionResult> deleteProductCategory(Guid id)
        {
            var response = await _productCategoryService.DeleteAsync(id);
            return Ok(response);
        }


        //[HttpPut]
        //public async Task<IActionResult> updateProductCategory(Guid id, [FromBody] UpdateProductCategoryViewModel updateProductCategoryViewModel)
        //{
        //    var respond = await _productCategoryService.Update(id, updateProductCategoryViewModel);
        //    if(respond.StatusCode == System.Net.HttpStatusCode.OK)
        //    {
        //        return Ok(respond);
        //    }
        //    else
        //    {
        //        return BadRequest(new { Message = respond.Message });
        //    }
        //}


        //[HttpPut]
        //public async Task<IActionResult> updateProductCategory(Guid id, [FromBody] ProductCategory productCategory)
        //{
        //    var response = await _productCategoryService.UpdateAsync(id, productCategory);
        //    return Ok(response);
        //}
    }
}