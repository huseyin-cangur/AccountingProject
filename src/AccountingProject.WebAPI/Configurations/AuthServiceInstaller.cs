


using AccountingProject.WebAPI.OptionsSetup;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace AccountingProject.WebAPI.Configurations
{
    public class AuthServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureOptions<JwtOptionSetup>();
            services.ConfigureOptions<JwtBearerOptionsSetup>();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddBearerToken();
        }
    }
}