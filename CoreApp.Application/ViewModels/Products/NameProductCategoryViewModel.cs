using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApp.Application.ViewModels.Products
{
    public class NameProductCategoryViewModel
    {
        public NameProductCategoryViewModel() { }

        /// <summary> Construct
        /// 
        /// </summary>
        /// <param name="productCategory"></param>
        
        public NameProductCategoryViewModel(ProductCategory productCategory) : this()
        {
            if (productCategory != null)
            {
                Id = productCategory.Id;
                Name = productCategory.Name;
            }
        }

        #region Method

        public Guid Id { get; set; }

        public string Name { get; set; }
        #endregion
    }
}
