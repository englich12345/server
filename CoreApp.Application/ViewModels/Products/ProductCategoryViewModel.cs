using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApp.Application.ViewModels.Products
{
    public class ProductCategoryViewModel
    {
        public ProductCategoryViewModel() { }

        /// <summary> Construct
        /// 
        /// </summary>
        /// <param name="productCategory"></param>
        
        public ProductCategoryViewModel(ProductCategory productCategory) : this()
        {
            if (productCategory != null)
            {
                Id = productCategory.Id;
                Name = productCategory.Name;
                Description = productCategory.Description;
                HomeOrder = productCategory.HomeOrder;
                Image = productCategory.Image;
                DateCreated = productCategory.DateCreated;
                DateModified = productCategory.DateModified;
                SeoAlias = productCategory.SeoAlias;
                SortOrder = productCategory.SortOrder;
                Status = productCategory.Status;
            }
        }

        #region Method

        public Guid Id { get; set; }

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

        #endregion
    }
}
