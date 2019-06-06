using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("RolePermissions")]
    public class RolePermission : BaseClass
    {

        public RolePermission() : base() { }

        public Guid RoleId { get; set; }
        public AppRole AppRole { get; set; }

        public Guid ActionId { get; set; }
        public ActionAuth ActionAuth { get; set; }

        public Guid ControllerId { get; set; }
        public ControllerAuth ControllerAuth { get; set; }

    }
}
