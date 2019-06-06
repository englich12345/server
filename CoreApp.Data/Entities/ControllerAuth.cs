using CoreApp.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApp.Data.Entities
{
    [Table("ControllerAuth")]
    public class ControllerAuth:BaseClass
    {
        public ControllerAuth() : base() { }
        public string Name { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}
