

using AccountingProject.Application.Services.AppServices;
using AccountingProject.Domain.App.Entities.Identity;
using AutoMapper;
using MediatR;
 

namespace AccountingProject.Application.Features.RoleFeatures.CreateRole
{
    public class CreateRoleHandler : IRequestHandler<CreateRoleRequest, CreateRoleResponse>
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public CreateRoleHandler(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        public async Task<CreateRoleResponse> Handle(CreateRoleRequest request, CancellationToken cancellationToken)
        {
            AppRole checkRole = await _roleService.GetByCode(request.Code);
            if (checkRole != null) throw new Exception("Bu rol daha önce kayıt edildi.");

            
            AppRole role = _mapper.Map<AppRole>(request);
            role.Id = Guid.NewGuid().ToString();

        
            await _roleService.AddAsync(role);

            return new();
        }
    }
}