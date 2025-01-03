


using AccountingProject.Domain.App.Entities.Identity;
using AccountingProject.Persistance;
using AccountingProject.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.WebAPI.Configurations
{
    public class PersistanceServiceInstaller : IServiceInstaller
    {
        private const string SectionName = "SqlServer";
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
              services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString(SectionName)));
              services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<AppDbContext>();
              services.AddAutoMapper(typeof(AssemblyReference).Assembly);
        }
    }
}