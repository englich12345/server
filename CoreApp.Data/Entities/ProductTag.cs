
using CoreApp.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApp.Data.Entities
{
    public class ProductTag:BaseClass
    {
        public ProductTag() : base() { }

        public Guid ProductId { get; set; }  
        
        public Guid TagId { get; set; }
        
        public Product Product { get; set; }

        public Tag Tag { get; set; }
    }
}
