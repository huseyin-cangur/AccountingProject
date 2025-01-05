

using Microsoft.AspNetCore.Identity;

namespace AccountingProject.Domain.App.Entities.Identity
{
    public class AppRole:IdentityRole<string>
    {
         public string Code { get; set; }
    }
}