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
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Application.Service
{
    public interface IRoleService
    {

        IQueryable<AppRole> GetAll();

        PagedList<RoleViewModel> ListRole(UserRequestListViewModel userRequestListViewModel);

        Task<AppRole> GetByIdAsync(Guid id);

        RolePermissionViewModel GetAction(Guid id);

        RolePermissionViewModel GetController(Guid id);

        Task<RespondModel> DeleteAsync(Guid id);

        Task<RespondModel> UpdateAsync(AppRole appRole);

        Task<RespondModel> AddRoleAsync(AddRoleViewModel addRoleViewModel);
    }

    public class RoleService : IRoleService
    {
        private readonly IRepository<AppRole> _repository;

        public RoleService(IRepository<AppRole> repository)
        {
            _repository = repository;
        }

        public async Task<RespondModel> AddRoleAsync(AddRoleViewModel addRoleViewModel)
        {
            if (addRoleViewModel != null)
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't add role"
                };
            }
            else
            {
                var role = AutoMapper.Mapper.Map<AppRole>(addRoleViewModel);
                foreach(var actionId in addRoleViewModel.ActionId)
                {
                    var rolePermission = new RolePermission()
                    {
                        ActionId = actionId,
                        RoleId = role.Id
                    };
                    if(role.RolePermissions == null)
                    {
                        role.RolePermissions = new List<RolePermission>();
                    }
                    role.RolePermissions.Add(rolePermission);
                }
                foreach (var controllerId in addRoleViewModel.ControllerId)
                {
                    var rolePermission = new RolePermission()
                    {
                        ControllerId = controllerId
                    };
                    if (role.RolePermissions == null)
                    {
                        role.RolePermissions = new List<RolePermission>();
                    }
                    role.RolePermissions.Add(rolePermission);
                }
                return await _repository.InsertAsync(role);
            }
        }

        public async Task<RespondModel> DeleteAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Can't find role"
                };
            }
            else
            {
                return await _repository.DeleteAsync(id);
            }
        }

        public IQueryable<AppRole> GetAll()
        {
            // return users without passwords
            return _repository.GetAll();
        }

        public async Task<AppRole> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public RolePermissionViewModel GetController(Guid id)
        {
            var role = _repository.GetAll()
                .Include(x => x.RolePermissions)
                .ThenInclude(x => x.ControllerAuth)
                .FirstOrDefault(x => x.Id == id);
            if (role == null)
                return null;
            else
                return new RolePermissionViewModel(role);
        }

        public RolePermissionViewModel GetAction(Guid id)
        {
            var role = _repository.GetAll()
                .Include(x => x.RolePermissions)
                .ThenInclude(x => x.ActionAuth)
                .FirstOrDefault(x => x.Id == id);
            if (role == null)
                return null;
            else
                return new RolePermissionViewModel(role);
        }

        public PagedList<RoleViewModel> ListRole(UserRequestListViewModel userRequestListViewModel)
        {
            var query = _repository.GetAll().Include(x => x.UserInRoles).ThenInclude(user => user.AppRole)
                .Where(x => ((string.IsNullOrEmpty(userRequestListViewModel.keyword)) || (x.name.Contains(userRequestListViewModel.keyword))))
                .Select(x => new RoleViewModel(x)).ToList();
            return new PagedList<RoleViewModel>(query, userRequestListViewModel.offset ?? CommonConstants.Config.DEFAULT_SKIP, userRequestListViewModel.limit ?? CommonConstants.Config.DEFAULT_TAKE);
        }

        public async Task<RespondModel> UpdateAsync(AppRole appRole)
        {
            if (appRole != null)
            {
                return new RespondModel()
                {
                    StatusCode = System.Net.HttpStatusCode.NotFound,
                    Message = "Nothing to update"
                };
            }
            else
            {
                return await _repository.UpdateAsync(appRole);
            }
        }
    }
}
