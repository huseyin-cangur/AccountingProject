

using AccountingProject.Domain.CompanyEntities;
using AccountingProject.Persistance.Constans;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingProject.Persistance.Configuration
{
    public class UniformChartOfAccountConfig : IEntityTypeConfiguration<UniformChartOfAccount>
    {
        public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
        {
            builder.ToTable(TableNames.UniformChartOfAccounts);
            builder.HasKey(p => p.Id);
        }
    }
}