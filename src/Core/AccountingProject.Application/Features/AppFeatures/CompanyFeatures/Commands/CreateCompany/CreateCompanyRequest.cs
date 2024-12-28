

using MediatR;

namespace AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public class CreateCompanyRequest : IRequest<CreateCompanyResponse>
    {
        public string Name { get; set; }
        public string DatabaseServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseUserId { get; set; }
        public string DatabasePassword { get; set; }

    }
}