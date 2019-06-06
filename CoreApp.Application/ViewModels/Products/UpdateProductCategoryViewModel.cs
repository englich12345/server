using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.Products
{
    public class UpdateProductCategoryViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public int SortOrder { set; get; }

        public Status Status { set; get; }

        public string SeoPageTitle { set; get; }

        public string SeoAlias { set; get; }

        public string SeoKeywords { set; get; }

        public string SeoDescription { set; get; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public ProductCategory UpdateProductCategory(ProductCategory productCategory)
        {
            productCategory.Name = Name;
            productCategory.Description = Description;
            HomeOrder = productCategory.HomeOrder = HomeOrder;
            Image = productCategory.Image = Image;
            productCategory.DateCreated = DateCreated;
            productCategory.DateModified = DateModified;
            productCategory.SeoAlias = SeoAlias;
            productCategory.SortOrder = SortOrder;
            productCategory.Status = Status;
            return productCategory;
        }
    }
}
