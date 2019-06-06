using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreApp.Application.ViewModels.System
{
    public class UserUpdateViewModel
    {
        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? BirthDay { set; get; }

        public string Avatar { get; set; }

        public Status Status { get; set; }

        public Guid[] Roles { get; set; }

        public AppUser GetUserFromModel(AppUser appUser)
        {
            appUser.Name = Name;
            appUser.Email = Email;
            appUser.Password = Password;
            appUser.FullName = FullName;
            appUser.BirthDay = BirthDay;
            appUser.Avatar = Avatar;
            appUser.Status = Status;
            if (!string.IsNullOrEmpty(Password))
                appUser.Password = Password;
            return appUser;
        }
    }
}
