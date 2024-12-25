

using AccountingProject.Domain.Abstraction;

namespace AccountingProject.Domain.App.Entities
{
    public class Company:Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxDepartment { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }

    }
}