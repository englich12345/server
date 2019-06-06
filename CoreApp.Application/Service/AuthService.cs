using CoreApp.Application.Helpers;
using CoreApp.Application.ViewModels.AuthenViewModel;
using CoreApp.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CoreApp.Application.Helpers.JwtHelper;

namespace CoreApp.Application.Service
{
    public interface IAuthService
    {
        Task<RespondModel> LoginAsync(AuthenViewModel authenViewModel);
    }

    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly IJwtHelper _jwtHelper;

        public AuthService(IUserService userService, IJwtHelper jwtHelper)
        {
            _userService = userService;
            _jwtHelper = jwtHelper;
        }
        
        public async Task<RespondModel> LoginAsync(AuthenViewModel authenViewModel)
        {
            var user = await _userService.Authenticate(authenViewModel.UserName, authenViewModel.Password);
            if (user != null)
            {
                var jwtPayload = new JwtPayload()
                {
                    Username = user.Name,
                    UserId = user.Id,
                    RoleIds = user.UserInRoles != null ? user.UserInRoles.Select(x => x.AppRoleId).ToList() : null
                };
                var token = _jwtHelper.GenerateToken(jwtPayload);

                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.OK,
                    data = token
                };
            }
            else
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.BadRequest,
                    Message = "Your Account is wrong!"
                };
            }
        }
    }
}
