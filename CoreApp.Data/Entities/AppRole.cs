using CoreApp.Data.Entities.Base;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApp.Data.Entities
{
    [Table("AppRoles")]
    public class AppRole : BaseClass
    {
        public AppRole() : base()
        {

        }

        public string name { get; set; }

        public List<UserInRole> UserInRoles { get; set; }

        public List<RolePermission> RolePermissions { get; set; }
    }
}
