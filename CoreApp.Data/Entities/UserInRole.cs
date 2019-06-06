using CoreApp.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApp.Data.Entities
{
    [Table("UserInRoles")]
    public class UserInRole : BaseClass
    {
        public UserInRole() : base() { }

        public Guid AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public Guid AppRoleId { get; set; }

        public AppRole AppRole { get; set; }
    }
}
