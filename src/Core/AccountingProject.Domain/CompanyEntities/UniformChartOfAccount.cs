
using AccountingProject.Domain.Abstraction;

namespace AccountingProject.Domain.CompanyEntities
{
    public class UniformChartOfAccount:Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        
        
    }
}