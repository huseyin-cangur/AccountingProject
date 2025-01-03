using Microsoft.AspNetCore.Identity;

namespace AccountingProject.Domain.App.Entities.Identity
{
    public class AppUser:IdentityUser<string>
    {
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpires { get; set; }
    }
}