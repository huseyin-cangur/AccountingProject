 
using System.ComponentModel.DataAnnotations.Schema;
using AccountingProject.Domain.Abstraction;
using AccountingProject.Domain.App.Entities.Identity;

namespace AccountingProject.Domain.App.Entities
{
    public class UserCompany:Entity
    {
        [ForeignKey("AppUser")]
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        [ForeignKey("Company")]
        public string CompanyId { get; set; }
        public Company Company { get; set; }
    }
}