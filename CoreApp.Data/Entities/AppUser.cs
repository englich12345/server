
using CoreApp.Data.Entities.Base;
using CoreApp.Data.Enums;
using CoreApp.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : BaseClass
    {
        public AppUser() { }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? BirthDay { set; get; }

        public decimal Balance { get; set; }

        public string Avatar { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public Status Status { get; set; }

        public List<UserInRole> UserInRoles { get; set; }
    }
}
