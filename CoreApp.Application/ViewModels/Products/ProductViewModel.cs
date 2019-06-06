using CoreApp.Data.Entities;
using CoreApp.Data.Entities.Base;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.Products
{
    public class ProductViewModel
    {
        public ProductViewModel() { }

        public ProductViewModel(Product product) : this()
        {
            Id = product.Id;
            Name = product.Name;
            Image = product.Image;
            Price = product.Price;
            OriginalPrice = product.OriginalPrice;
            PromotionPrice = product.PromotionPrice;
            Description = product.Description;
            Content = product.Content;
            Tags = product.Tags;
            Unit = product.Unit;
            Status = product.Status;
            SeoAlias = product.SeoAlias;
            //ProductCategoryId = product.CategoryId;
            //ProductCategoryName = product.ProductCategory.Name;

            ProductCategory = new
            {
                product.CategoryId,
                product.ProductCategory.Name
            };

        }
        
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public decimal? PromotionPrice { get; set; }

        public decimal OriginalPrice { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        public string Tags { get; set; }

        public string Unit { get; set; }

        public string SeoPageTitle { set; get; }

        public string SeoAlias { set; get; }

        public string SeoKeywords { set; get; }

        public string SeoDescription { set; get; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public Status Status { set; get; }

        public string ProductCategoryName { set; get; }

        public object ProductCategory { set; get; }

        public Guid ProductCategoryId { get; set; }
    }
}
