

using AccountingProject.Application.Features.CompanyFeatures.CreateUCAF;

namespace AccountingProject.Application.Services.CompanyServices
{
    public interface IUCAFService
    {
        Task CreateAsync(CreateUCAFRequest request);
    }
}