


using AccountingProject.Application.Services.AppServices;
using AccountingProject.Application.Services.CompanyServices;
using AccountingProject.Domain;
using AccountingProject.Persistance;
using AccountingProject.Persistance.Repositories.UCAFRepositories;
using AccountingProject.Persistance.Services.AppsServices;
using AccountingProject.Persistance.Services.CompanyServices;

namespace AccountingProject.WebAPI.Configurations
{
    public class PersistanceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            #region Context UnitOfWork
            services.AddScoped<IContextService, ContextService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            #endregion

            #region Services
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IUCAFService, UCAFService>();
            services.AddScoped<IRoleService, RoleService>();    
            #endregion

            #region Repositories
            services.AddScoped<UCAFCommandRepository, UCAFCommandRepository>();
            services.AddScoped<UCAFQueryRepository, UCAFQueryRepository>();
            #endregion


        }
    }
}