using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("BlogTags")]
    public class BlogTag : BaseClass
    {
        public BlogTag() : base() { }

        public Guid BlogId { set; get; }


        public Guid TagId { set; get; }

        public Blog Blog { get; set; }

        public Tag Tag { get; set; }
    }
}
