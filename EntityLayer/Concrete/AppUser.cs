using Microsoft.AspNetCore.Identity;
using System;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string? Image { get; set; }
        public string Name { get; set; }
        public string? CustomerRole { get; set; }
        public bool IsDeactive { get; set; }
        public bool IsAgent { get; set; }
        public bool IsPremium { get; set; }

        public List<Home> Homes { get; set; }
    }
}
