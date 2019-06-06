using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreApp.Data.Entities.Base
{
    public class BaseClass
    {
        public BaseClass()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }
    }
}
