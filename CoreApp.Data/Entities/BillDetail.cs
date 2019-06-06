using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("BillDetails")]
    public class BillDetail : BaseClass
    {
        public BillDetail():base() { }

        public BillDetail(Guid id, Guid billId, Guid productId, int quantity, decimal price, Guid colorId, Guid sizeId)
        {
            Id = id;
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            ColorId = colorId;
            SizeId = sizeId;
        }

        public BillDetail(Guid billId, Guid productId, int quantity, decimal price, Guid colorId, Guid sizeId)
        {
            BillId = billId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            ColorId = colorId;
            SizeId = sizeId;
        }
        public Guid BillId { set; get; }

        public Guid ProductId { set; get; }

        public int Quantity { set; get; }

        public decimal Price { set; get; }

        public Guid ColorId { get; set; }

        public Guid SizeId { get; set; }

        [ForeignKey("BillId")]
        public virtual Bill Bill { set; get; }

        [ForeignKey("ProductId")]
        public virtual Product Product { set; get; }

        [ForeignKey("ColorId")]
        public virtual Color Color { set; get; }

        [ForeignKey("SizeId")]
        public virtual Size Size { set; get; }
    }
}
