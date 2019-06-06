using System;
using System.Collections.Generic;
using System.Text;
using CoreApp.Data.Entities.Base;
using CoreApp.Data.Enums;
using CoreApp.Data.Interfaces;

namespace CoreApp.Data.Entities
{
    public class ProductCategory : BaseClass, IHasSeoMetaData, ISwitchable, ISortable, IDateTracking
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid? ParentId { get; set; }

        public int? HomeOrder { get; set; }

        public string Image { get; set; }

        public bool? HomeFlag { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public int SortOrder { get; set; }

        public Status Status { get; set; }

        public string SeoPageTitle { get; set; }

        public string SeoAlias { get; set; }

        public string SeoKeyWords { get; set; }

        public string SeoDescription { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
