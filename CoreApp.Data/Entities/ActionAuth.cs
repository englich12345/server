using CoreApp.Data.Entities.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreApp.Data.Entities
{
    [Table("ActionAuth")]
    public class ActionAuth:BaseClass
    {
        public ActionAuth() : base() { }
        public string Name { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
    }
}
