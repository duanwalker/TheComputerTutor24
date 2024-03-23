using Microsoft.AspNetCore.Identity;

namespace TheComputerTutor24.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? DisplayName { get; set; }
        public byte[]? ProfileImage { get; set; }
         public string? ProfileImageURL { get; set; }
        public string? Bio { get; set; } // Short user bio
        public bool? PrivateProfile { get; set; }
        public string? Role { get; set; }
        public bool? ReceiveEmailNotifications { get; set; }
        public string[]? Favorites { get; set; }
        public string[]? WatchLater { get; set; }
        public string[]? Subscriptions { get; set; }
        public string? Verified { get; set; }
        public float? TrustScore { get; set; }
        public string? LinkedInURL { get; set; }
         public string? TwitterURL { get; set; }
         public string? GitHubURL { get; set; }
         public string? StackOverflowURL { get; set; }
         public string[]? Badges { get; set; }
         public string[]? Achievements { get; set; }
         public string[]? Views { get; set; }
    }
}
