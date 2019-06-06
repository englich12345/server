using CoreApp.Data.Entities;
using System.Linq;

namespace CoreApp.Application.ViewModels.System
{
    public class RolePermissionViewModel
    {
        public string[] controller;
        public string[] action;

        public RolePermissionViewModel(AppRole appRole)
        {
            action = appRole.RolePermissions.Select(x => x.ActionAuth.Name).ToArray() ?? null;
            controller = appRole.RolePermissions.Select(x => x.ControllerAuth.Name).ToArray() ?? null;
        }
    }
}
