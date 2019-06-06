using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CoreApp.Application.ViewModels.AuthenViewModel
{
    public class AuthenViewModel
    {
        public string Email { get; set; }

        [StringLength(512)]
        [Required]
        public string UserName { get; set; }

        [StringLength(512)]
        [Required]
        public string Password { get; set; }
    }
}
