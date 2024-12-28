

using AccountingProject.Application.Services.AppServices;
using MediatR;

namespace AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase
{
    public class MigrateDatabaseCompanyHandler : IRequestHandler<MigrateDatabaseCompanyRequest, MigrateDatabaseCompanyResponse>
    {
        private readonly ICompanyService _companyService;

        public MigrateDatabaseCompanyHandler(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        public async Task<MigrateDatabaseCompanyResponse> Handle(MigrateDatabaseCompanyRequest request, CancellationToken cancellationToken)
        {
            await _companyService.MigrateCompanyDatabase();
            return new MigrateDatabaseCompanyResponse();
        }
    }
}