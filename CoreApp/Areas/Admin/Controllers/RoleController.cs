using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Application.Service;
using CoreApp.Application.ViewModels.PageViewModel;
using CoreApp.Application.ViewModels.System;
using CoreApp.Data.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace CoreApp.Areas.Admin.Controllers
{
    [Route("admin/roles")]
    [EnableCors("CorsPolicy")]
    public class RoleController : BaseController
    {
        IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
        
        [HttpGet]
        public IActionResult GetList(UserRequestListViewModel userRequestListViewModel)
        {
            var model = _roleService.ListRole(userRequestListViewModel);
            return Ok(model);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> getById(Guid id)
        {
            var model = await _roleService.GetByIdAsync(id);
            return Ok(model);
        }

        [HttpPost]
        public async Task<IActionResult> addRole([FromBody] AddRoleViewModel addRoleViewModel)
        {
            var respond = await _roleService.AddRoleAsync(addRoleViewModel);
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
        public async Task<IActionResult> updateRole([FromBody] AppRole appRole)
        {
            var response = await _roleService.UpdateAsync(appRole);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> deleteRole(Guid id)
        {
            var response = await _roleService.DeleteAsync(id);
            return Ok(response);
        }
        
        
    }
}
