using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityDemo
{
    public class ApplicationRole : IdentityRole
    {
        
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; }
    }

}

