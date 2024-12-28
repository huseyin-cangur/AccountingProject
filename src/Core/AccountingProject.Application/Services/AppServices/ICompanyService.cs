

using AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingProject.Domain.App.Entities;

namespace AccountingProject.Application.Services.AppServices
{
    public interface ICompanyService
    {

        Task CreateCompanyAsync(CreateCompanyRequest request);
        Task<Company?> GetCompanyByName(string companyName);

        Task MigrateCompanyDatabase();

    }
}