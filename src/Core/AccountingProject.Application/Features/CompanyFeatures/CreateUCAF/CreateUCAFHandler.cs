

using AccountingProject.Application.Services.CompanyServices;
using MediatR;

namespace AccountingProject.Application.Features.CompanyFeatures.CreateUCAF
{
    public class CreateUCAFHandler : IRequestHandler<CreateUCAFRequest, CreateUCAFResponse>
    {
        private readonly IUCAFService _ucafService;

        public CreateUCAFHandler(IUCAFService ucafService)
        {
            _ucafService = ucafService;
        }

        public async Task<CreateUCAFResponse> Handle(CreateUCAFRequest request, CancellationToken cancellationToken)
        {
            await _ucafService.CreateAsync(request);
            return new();
        }
    }
}