
using AccountingProject.Application.Services.AppServices;
using AccountingProject.Domain.App.Entities;
using MediatR;

namespace AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResponse>
    {
        private readonly ICompanyService _companyService;

        public CreateCompanyHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<CreateCompanyResponse> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
        {
            Company company = await _companyService.GetCompanyByName(request.Name);
            if (company != null) throw new Exception("Bu şirket adı daha önce kullanılmış!");
            await _companyService.CreateCompanyAsync(request);
            return new();
        }
    }
}