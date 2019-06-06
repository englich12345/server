using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("Sizes")]
    public class Size : BaseClass
    {
        public Size() : base() { }
        [StringLength(250)]
        public string Name
        {
            get; set;
        }
    }
}
