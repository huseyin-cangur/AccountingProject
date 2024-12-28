
using AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingProject.Application.Services.AppServices;
using AccountingProject.Domain.App.Entities;
using AccountingProject.Persistance.Context;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Persistance.Services.AppsServices
{
    public class CompanyService : ICompanyService
    {
        private static readonly Func<AppDbContext, string, Task<Company?>> GetCompanyByNameCompiled =
        EF.CompileAsyncQuery((AppDbContext context, string name) =>
        context.Set<Company>().FirstOrDefault(p => p.Name == name));
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public CompanyService(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public async Task CreateCompanyAsync(CreateCompanyRequest request)
        {
            Company company = _mapper.Map<Company>(request);
            company.Id = Guid.NewGuid().ToString();
            await _appDbContext.Set<Company>().AddAsync(company);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task<Company?> GetCompanyByName(string companyName)
        {
            return await GetCompanyByNameCompiled(_appDbContext, companyName);
        }
        public async Task MigrateCompanyDatabase()
        {
            var companies =await  _appDbContext.Set<Company>().ToListAsync();

            foreach (var company in companies)
            {
                var db = new CompanyDbContext(company);
                db.Database.Migrate();
            }
        }
    }
}