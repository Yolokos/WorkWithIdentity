using Microsoft.AspNetCore.Identity;

namespace IdentityWebApp.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
