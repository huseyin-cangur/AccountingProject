

using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Domain
{
    public interface IContextService
    {
        DbContext CreateDbContextInstance(string companyId);
        
    }
}