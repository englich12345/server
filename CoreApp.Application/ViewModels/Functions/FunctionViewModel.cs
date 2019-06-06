using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.Functions
{
    public class FunctionViewModel
    {
        public FunctionViewModel(){ }

        public FunctionViewModel(Function function): this()
        {
            if(function != null)
            {
                
            }
        }
        public Guid Id { get; set; }
        public string Name { set; get; }

        public string URL { set; get; }
        
        public Guid ParentId { set; get; }

        public string IconCss { get; set; }

        public int SortOrder { set; get; }

        public Status Status { set; get; }
    }
}
