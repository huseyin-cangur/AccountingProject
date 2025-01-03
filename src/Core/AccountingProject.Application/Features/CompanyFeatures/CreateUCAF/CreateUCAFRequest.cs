

using MediatR;

namespace AccountingProject.Application.Features.CompanyFeatures.CreateUCAF
{
    public class CreateUCAFRequest : IRequest<CreateUCAFResponse>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string CompanyId { get; set; }
    }
}