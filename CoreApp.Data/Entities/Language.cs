using CoreApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using CoreApp.Data.Enums;
using CoreApp.Data.Entities.Base;

namespace CoreApp.Data.Entities
{
    [Table("Languages")]
    public class Language : BaseClass, ISwitchable
    {
        public Language() : base() { }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }

        public Status Status { get; set; }
    }
}
