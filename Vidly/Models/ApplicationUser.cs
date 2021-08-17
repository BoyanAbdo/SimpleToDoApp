using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Vidly.Models
{
    public class ApplicationUser : IdentityUser
    {
        public List<Task> Tasks { get; set; }
    }
}
