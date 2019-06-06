using CoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.System
{
    public class ActionViewModel
    {
        public ActionViewModel(ActionAuth actionAuth)
        {
            Id = actionAuth.Id;
            Name = actionAuth.Name;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
