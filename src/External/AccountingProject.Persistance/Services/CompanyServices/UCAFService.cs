
using AccountingProject.Application.Features.CompanyFeatures.CreateUCAF;
using AccountingProject.Application.Services.CompanyServices;
using AccountingProject.Domain;
using AccountingProject.Domain.CompanyEntities;
using AccountingProject.Persistance.Context;
using AccountingProject.Persistance.Repositories.UCAFRepositories;
using AutoMapper;
 


namespace AccountingProject.Persistance.Services.CompanyServices
{
    public class UCAFService : IUCAFService
    {
        private CompanyDbContext _context;
        private readonly UCAFCommandRepository _repository;
        private readonly IContextService _contextService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UCAFService(UCAFCommandRepository repository, IContextService contextService, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _contextService = contextService;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateAsync(CreateUCAFRequest request)
        {
            _context =  (CompanyDbContext)_contextService.CreateDbContextInstance(request.CompanyId);
            _repository.SetDbContextInstance(_context);
            _unitOfWork.SetDbContextInstance(_context);

            UniformChartOfAccount uniformChartOfAccount = _mapper.Map<UniformChartOfAccount>(request);
            uniformChartOfAccount.Id = Guid.NewGuid().ToString();
            await _repository.AddAsync(uniformChartOfAccount);
            await _unitOfWork.SaveChangesAsync();


        }
    }
}