using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.PageViewModel
{
    public class UserRequestListViewModel : RequestListViewModel
    {
        public UserRequestListViewModel() : base() {
            IsDesc = false;
        }
        public string keyword { get; set; }
        public string SortName { get; set; }
        public bool IsDesc { get; set; }
    }
}
