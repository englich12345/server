using CoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.System
{
    public class ControllerViewModel
    {
        public ControllerViewModel(ControllerAuth controllerAuth)
        {
            if(controllerAuth != null)
            {
                Id = controllerAuth.Id;
                Name = controllerAuth.Name;
            }
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
