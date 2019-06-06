using CoreApp.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreApp.Data.Entities
{
    public class Tag:BaseClass
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }

        public List<BlogTag> BlogTags { get; set; }

        public List<ProductTag> ProductTags { get; set; }
    }
}
