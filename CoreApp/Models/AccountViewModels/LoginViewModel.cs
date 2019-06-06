using CoreApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models.AccountViewModels
{
    public class LoginViewModel
    {
        public LoginViewModel() { }

        [Required]
        public string Email { get; set; }


        public string Password { get; set; }

        [Display(Name = "Remember")]
        public bool RememberMe { get; set; }
    }
}

