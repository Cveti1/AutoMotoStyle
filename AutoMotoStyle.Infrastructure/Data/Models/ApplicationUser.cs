﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoMotoStyle.Infrastructure.Data.DataConstants;

namespace AutoMotoStyle.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser

    {
        [Required]
        [StringLength(MaxUserFirstName)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(MaxUserLastName)]
        public string LastName { get; set; } = null!;

        public bool IsActive { get; set; } = true;
    }
}
