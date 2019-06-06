using CoreApp.Application.Utilities;
using CoreApp.Application.ViewModels.PageViewModel;
using CoreApp.Application.ViewModels.System;
using CoreApp.Data.Entities;
using CoreApp.Persistence.Constants;
using CoreApp.Persistence.Repository;
using CoreApp.Utilities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Application.Service
{
    public interface IUserService
    {
        Task<AppUser> Authenticate(string username, string password);

        PagedList<UserViewModel> ListUser(UserRequestListViewModel userRequestListViewModel);

        UserDetailViewModel GetByIdAsync(Guid id);
        
        Task<RespondModel> DeleteAsync(Guid id);

        Task<RespondModel> UpdateAsync(Guid id, UserUpdateViewModel userUpdateViewModel);

        Task<RespondModel> AddUserAsync(UserRegisterViewModel userRegisterViewModel);
    }

    public class UserService : IUserService
    {
        private readonly IRepository<AppUser> _repository;

        public UserService(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public UserDetailViewModel GetByIdAsync(Guid id)
        {
            var user = _repository.GetAll()
                .Include(x => x.UserInRoles)
                .ThenInclude(role => role.AppRole)
                .FirstOrDefault(x => x.Id == id);
            if (user == null)
                return null;
            else
                return new UserDetailViewModel(user);
        }

        private List<string> GetAllPropertyNameOfUserViewModel()
        {
            var userViewModel = new UserViewModel();
            var type = userViewModel.GetType();

            return ReflectionUtilities.GetAllPropertyNamesOfType(type);
        }

        public PagedList<UserViewModel> ListUser(UserRequestListViewModel userRequestListViewModel)
        {
            var query = _repository.GetAll().Include(x => x.UserInRoles).ThenInclude(user => user.AppRole)
                .Where(x => ((string.IsNullOrEmpty(userRequestListViewModel.keyword)) || (x.Email.Contains(userRequestListViewModel.keyword))|| (x.Name.Contains(userRequestListViewModel.keyword))))
                .Select(x => new UserViewModel(x)).ToList();
            var userViewModelProperties = GetAllPropertyNameOfUserViewModel();
            var requestPropertyName = !string.IsNullOrEmpty(userRequestListViewModel.SortName) ? userRequestListViewModel.SortName.ToLower() : string.Empty;
            string matchedPropertyName = string.Empty;

            foreach (var userViewModelProperty in userViewModelProperties)
            {
                var lowerTypeViewModelProperty = userViewModelProperty.ToLower();
                if (lowerTypeViewModelProperty.Equals(requestPropertyName))
                {
                    matchedPropertyName = userViewModelProperty;
                    break;
                }
            }

            if (string.IsNullOrEmpty(matchedPropertyName))
            {
                matchedPropertyName = "Name";
            }

            var type = typeof(UserViewModel);
            var sortProperty = type.GetProperty(matchedPropertyName);
            query = userRequestListViewModel.IsDesc ? query.OrderByDescending(x => sortProperty.GetValue(x, null)).ToList(): query.OrderBy(x => sortProperty.GetValue(x, null)).ToList();
            return new PagedList<UserViewModel>(query, userRequestListViewModel.offset ?? CommonConstants.Config.DEFAULT_SKIP, userRequestListViewModel.limit ?? CommonConstants.Config.DEFAULT_TAKE);
        }

        public async Task<RespondModel> AddUserAsync(UserRegisterViewModel userRegisterViewModel)
        {
            var user = await _repository.FetchFirstAsync(x => x.Email == userRegisterViewModel.Email); 
            if(user != null)
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "User is exist"
                };
            }
            else
            {
                var newUser = AutoMapper.Mapper.Map<AppUser>(userRegisterViewModel);
                if (userRegisterViewModel.Roles!=null)
                {
                    foreach (var roleId in userRegisterViewModel.Roles)
                    {
                        var userInRole = new UserInRole()
                        {
                            AppUserId = newUser.Id,
                            AppRoleId = roleId
                        };
                        if (newUser.UserInRoles == null)
                        {
                            newUser.UserInRoles = new List<UserInRole>();
                        }
                        newUser.UserInRoles.Add(userInRole);
                    }
                }
                
                return await _repository.InsertAsync(newUser);
            }
        }

        public async Task<AppUser> Authenticate(string username, string password)
        {
            return await _repository.FetchFirstAsync(x => x.Name == username && x.Password == password);
        }

        public async Task<RespondModel> UpdateAsync(Guid id, UserUpdateViewModel userUpdateViewModel)
        {
            var user = await _repository.FetchFirstAsync(x => x.Id == id);
            if (user == null)
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't find user"
                };
            }
            else
            {
                var updateUser = userUpdateViewModel.GetUserFromModel(user);
                updateUser.UserInRoles = new List<UserInRole>();
                foreach (var roleId in userUpdateViewModel.Roles)
                {
                    var userInRole = new UserInRole()
                    {
                        AppUserId = updateUser.Id,
                        AppRoleId = roleId
                    };
                    updateUser.UserInRoles.Add(userInRole);
                }
                return await _repository.UpdateAsync(updateUser);
            }
        }

        public async Task<RespondModel> DeleteAsync(Guid id)
        {
            if(id == Guid.Empty)
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't find user"
                };
            }
            else
            {
                return await _repository.DeleteAsync(id);
            }
        }
    }
}
