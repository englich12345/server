using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.System
{
    public class AddRoleViewModel
    {
        public string Name { get; set; }

        public Guid[] ActionId { get; set; }

        public Guid[] ControllerId { get; set; }
    }
}
