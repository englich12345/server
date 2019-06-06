using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("Footers")]
    public class Footer : BaseClass
    {
        public Footer() : base() { }

        [Required]
        public string Content { set; get; }
    }
}
