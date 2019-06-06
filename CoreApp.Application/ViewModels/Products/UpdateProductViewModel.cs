using CoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreApp.Application.ViewModels.Products
{
    public class UpdateProductViewModel
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public decimal PromotionPrice { get; set; }

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

        public Product UpdateProduct(Product product)
        {
            product.Name = Name;
            product.Price = Price;
            product.Description = Description;
            product.Image = Image;
            product.PromotionPrice = PromotionPrice;
            product.OriginalPrice = OriginalPrice;
            product.Content = Content;
            product.Unit = Unit;
            product.SeoAlias = SeoAlias;
            return product;
        } 
    }
}
