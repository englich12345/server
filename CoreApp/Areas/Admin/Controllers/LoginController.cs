using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreApp.Application.Helpers;
using CoreApp.Application.Service;
using CoreApp.Application.ViewModels.AuthenViewModel;
using CoreApp.Data.Entities;
using CoreApp.Models.AccountViewModels;
using CoreApp.Utilities.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CoreApp.Areas.Admin.Controllers
{
    [EnableCors("CorsPolicy")]
    public class LoginController : BaseController
    {
        private readonly IAuthService _authService;
        private readonly IJwtHelper _jwtHelper;

        public LoginController(IAuthService authService, IJwtHelper jwtHelper)
        {
            _authService = authService;
            _jwtHelper = jwtHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Authen([FromBody] AuthenViewModel authenViewModel)
        {
            var responseModel = await _authService.LoginAsync(authenViewModel);
            if(responseModel.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok(responseModel);
            }
            else
            {
                return BadRequest(new { Message = responseModel.Message });
            }
        }
    }
}