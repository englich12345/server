using CoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.System
{
    public class RoleViewModel
    {
        public RoleViewModel() { }
        public RoleViewModel(AppRole appRole)
        {
            if(appRole != null)
            {
                Id = appRole.Id;
                Name = appRole.name;
            }
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
