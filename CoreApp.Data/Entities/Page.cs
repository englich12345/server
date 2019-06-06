using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;
using CoreApp.Data.Enums;
using CoreApp.Data.Interfaces;

namespace CoreApp.Data.Entities
{
    [Table("Pages")]
    public class Page : BaseClass,ISwitchable
    {
        public Page():base() { }

        public Page(Guid id, string name, string alias, 
            string content, Status status)
        {
            Id = id;
            Name = name;
            Alias = alias;
            Content = content;
            Status = status;
        }
        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
        public Status Status { set; get; }
    }
}
