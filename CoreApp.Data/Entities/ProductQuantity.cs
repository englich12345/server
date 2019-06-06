using CoreApp.Data.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApp.Data.Entities
{
    [Table("ProductQuantities")]
    public class ProductQuantity : BaseClass
    {
        public ProductQuantity() : base() { }

        [Column(Order = 1)]
        public Guid ProductId { get; set; }

        [Column(Order = 2)]
        public Guid SizeId { get; set; }


        [Column(Order = 3)]
        public Guid ColorId { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }

        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
    }
}
