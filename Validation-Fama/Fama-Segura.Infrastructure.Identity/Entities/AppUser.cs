using Microsoft.AspNetCore.Identity;

namespace Fama_Segura.Infrastructure.Identity.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; } 
        public string LastName { get; set; } 
        public string Cedula { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
