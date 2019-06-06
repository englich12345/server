using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Application.Service;
using CoreApp.Application.ViewModels.PageViewModel;
using CoreApp.Application.ViewModels.System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Areas.Admin.Controllers
{
    [Route("api/users")]
    [EnableCors("CorsPolicy")]
    public class UserController : Controller
    {
        IUserService _userService;
        IRoleService _roleService;
        public UserController(IUserService userService, IRoleService roleService)
        {
            _userService = userService;
            _roleService = roleService;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetList(UserRequestListViewModel userRequestListViewModel)
        {
            var model =  _userService.ListUser(userRequestListViewModel);
            return Ok(model);
        }

        [HttpGet]
        [Route("list/{id}")]
        public ActionResult getById(Guid id)
        {
            var model = _userService.GetByIdAsync(id);
            return Ok(model);
        }

        [HttpPost("list")]
        public async Task<IActionResult> RegisterUserAsync([FromBody] UserRegisterViewModel userRegisterViewModel)
        {
            var respond = await _userService.AddUserAsync(userRegisterViewModel);
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
        public async Task<IActionResult> updateUser(Guid id, [FromBody] UserUpdateViewModel userUpdateViewModel)
        {
            var response = await _userService.UpdateAsync(id, userUpdateViewModel);
            return Ok(response);
        }

        [HttpDelete]
        [Route("list/{id}")]
        public async Task<IActionResult> deleteUser(Guid id)
        {
            var response = await _userService.DeleteAsync(id);
            return Ok(response);
        }



        //[Route("index")]
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}