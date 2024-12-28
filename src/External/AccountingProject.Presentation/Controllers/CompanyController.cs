

using AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using AccountingProject.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AccountingProject.Presentation.Controllers
{
    public class CompanyController : ApiContoller
    {
        public CompanyController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]

        public async Task<IActionResult> Create(CreateCompanyRequest request)
        {
            CreateCompanyResponse response = await _mediator.Send(request);
            return Ok(response);

        }
        [HttpGet]
        public async Task<IActionResult> MigrateCompanyDatabase()
        {
            MigrateDatabaseCompanyRequest migrateDatabaseCompanyRequest = new();
            MigrateDatabaseCompanyResponse response = await _mediator.Send(migrateDatabaseCompanyRequest);

            return Ok(response);
        }
    }
}