﻿using CoreApp.Data.Enums;
using System;

namespace CoreApp.Application.ViewModels.Products
{
    public class AddProductCategoryViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public int SortOrder { set; get; }

        public Status Status { set; get; }

        public string SeoPageTitle { set; get; }

        public string SeoAlias { set; get; }

        public string SeoKeywords { set; get; }

        public string SeoDescription { set; get; }
    }
}
