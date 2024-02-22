using Microsoft.AspNetCore.Identity;

namespace TheComputerTutor24.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public byte[]? ProfileImage { get; set; }
    }
}
