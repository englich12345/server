using CoreApp.Data.Entities;
using CoreApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreApp.Application.ViewModels.System
{
    public class UserViewModel
    {
        public UserViewModel() { }

        public UserViewModel(AppUser appUser):this()
        {
            Id = appUser.Id;
            Name = appUser.Name;
            Email = appUser.Email;
            FullName = appUser.FullName;
            PhoneNumber = appUser.PhoneNumber;
            BirthDay = appUser.BirthDay;
            Avatar = appUser.Avatar;
            Status = appUser.Status;
            Roles = appUser.UserInRoles != null ? appUser.UserInRoles.Select(x => new RoleViewModel(x.AppRole)).ToArray() : null;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime? BirthDay { set; get; }

        public string Avatar { get; set; }

        public Status Status { get; set; }

        public RoleViewModel[] Roles { get; set; }
    }
}
