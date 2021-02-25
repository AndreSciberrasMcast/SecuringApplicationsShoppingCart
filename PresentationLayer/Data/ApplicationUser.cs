﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationLayer.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public String Address { get; set; }

    }
}