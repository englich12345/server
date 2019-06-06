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
    [Route("api/products")]
    [EnableCors("CorsPolicy")]
    public class ProductController : BaseController
    {
        public IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        //[HttpGet]
        //public IActionResult GetAll()
        //{
        //    var model = _productService.GetAll();
        //    return Ok(model);
        //}

        [HttpGet]
        [Route("list")]
        public IActionResult GetAllPage(UserRequestListViewModel userRequestListViewModel)
        {
            var model = _productService.GetList(userRequestListViewModel);
            return Ok(model);
        }

        [HttpGet]
        [Route("list/{id}")]
        public async Task<IActionResult> GetById(Guid Id)
        {
            var model = await _productService.GetByIdAsync(Id);
            return Ok(model);
        }

        [HttpPost]
        [Route("list")]
        public async Task<IActionResult> addProduct([FromBody] AddProductViewModel addProductViewModel)
        {
            var respond = await _productService.AddAsync(addProductViewModel);
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
        public async Task<IActionResult> updateProduct(Guid id, [FromBody] UpdateProductViewModel updateProductViewModel)
        {
            var respond = await _productService.UpdateAsync(id, updateProductViewModel);
            if (respond.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(respond.data);
            }
            else
            {
                return BadRequest(new { Message = respond.Message });
            }
        }

        [HttpDelete]
        [Route("list/{id}")]
        public async Task<IActionResult> deleteProduct(Guid id)
        {
            var respond = await _productService.DeleteAsync(id);
            if (respond.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(respond.data);
            }
            else
            {
                return BadRequest(new { Message = respond.Message });
            }
        }
    }
}