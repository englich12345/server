using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistmentPage : BaseClass
    {
        public AdvertistmentPage() : base() { }

        public string Name { get; set; }

        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}
