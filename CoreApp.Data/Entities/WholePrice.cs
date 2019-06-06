using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("WholePrices")]
    public class WholePrice : BaseClass
    {
        public WholePrice() : base() { }
        
        public Guid ProductId { get; set; }

        public int FromQuantity { get; set; }

        public int ToQuantity { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
