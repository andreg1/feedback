using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace feedback.Models
{
    public class CustomUser : IdentityUser<int>
    {
        public UserProfile ProfileData { get; set; }
    }
}
