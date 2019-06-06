using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.PageViewModel
{
    public class BaseRequestListViewModel
    {
        public int? offset { get; set; }
        public int? limit { get; set; }
    }
}
