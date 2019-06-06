using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("AdvertistmentPositions")]
    public class AdvertistmentPosition : BaseClass
    {
        public AdvertistmentPosition() : base() { }

        public Guid? PageId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [ForeignKey("PageId")]
        public virtual AdvertistmentPage AdvertistmentPage { get; set; }

        public virtual ICollection<Advertistment> Advertistments { get; set; }
    }
}
