﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Blazor_Demo.Shared.Entities
{
    public class User
    {
        [Required]
        [StringLength(10, ErrorMessage ="User name is too long. Only allow 10 characters.")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="The password is required.")]
        public string Password { get; set; }
    }
}
