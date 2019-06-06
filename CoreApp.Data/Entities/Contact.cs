using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CoreApp.Data.Entities.Base;
using CoreApp.Data.Enums;

namespace CoreApp.Data.Entities
{
    [Table("ContactDetails")]
    public class Contact : BaseClass
    {
        public Contact():base() { }

        public Contact(Guid id, string name, string phone, string email,
            string website, string address, string other, double? longtitude, double? latitude, Status status)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Email = email;
            Website = website;
            Address = address;
            Other = other;
            Lng = longtitude;
            Lat = latitude;
            Status = status;
        }
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(50)]
        public string Phone { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(250)]
        public string Website { set; get; }

        [StringLength(250)]
        public string Address { set; get; }

        public string Other { set; get; }

        public double? Lat { set; get; }

        public double? Lng { set; get; }

        public Status Status { set; get; }
    }
}
