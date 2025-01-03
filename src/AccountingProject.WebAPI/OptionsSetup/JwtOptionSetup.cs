

using AccountingProject.Infrastructure.Authencation;
using Microsoft.Extensions.Options;

namespace AccountingProject.WebAPI.OptionsSetup
{
    public class JwtOptionSetup : IConfigureOptions<JwtOptions>
    {
        private const string Jwt = nameof(Jwt);
        private readonly IConfiguration _configuration;
        public JwtOptionSetup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(JwtOptions options)
        {
            _configuration.GetSection(Jwt).Bind(options);
        }
    }
}