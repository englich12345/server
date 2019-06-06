using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.Filters.Models
{
    public class CustomAuthorizeModel
    {
        public List<Guid> RoleId { get; set; }

        public string Controller { get; set; }

        public string[] Action { get; set; }
    }
}
