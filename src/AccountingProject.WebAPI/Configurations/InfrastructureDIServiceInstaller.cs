


using AccountingProject.Application.Abstraction;
using AccountingProject.Infrastructure.Authencation;

namespace AccountingProject.WebAPI.Configurations
{
    public class InfrastructureDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IJwtProvider,JwtProvider>();
        }
    }
}