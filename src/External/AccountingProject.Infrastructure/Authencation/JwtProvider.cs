

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using AccountingProject.Application.Abstraction;
using AccountingProject.Domain.App.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


namespace AccountingProject.Infrastructure.Authencation
{
    public class JwtProvider : IJwtProvider
    {
        private readonly JwtOptions _jwtOptions;
        private readonly UserManager<AppUser> userManagerr;

        public JwtProvider(IOptions<JwtOptions> jwtOptions, UserManager<AppUser> userManagerr)
        {
            _jwtOptions = jwtOptions.Value;
            this.userManagerr = userManagerr;
        }
        public async Task<string> CreateTokenAsync(AppUser user, List<string> roles)
        {
            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.FullName),
                new Claim(JwtRegisteredClaimNames.Email,user.Email),
                new Claim(ClaimTypes.Authentication,user.Id),
                new Claim(ClaimTypes.Role,String.Join(",",roles))

            };

            DateTime expires = DateTime.Now.AddDays(1);

            JwtSecurityToken JwtSecuritytoken = new(
               issuer: _jwtOptions.Issuer,
               audience: _jwtOptions.Audience,
               claims: claims,
               notBefore: DateTime.Now,
               expires: expires,
               signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)), SecurityAlgorithms.HmacSha256)

            );
            string token = new JwtSecurityTokenHandler().WriteToken(JwtSecuritytoken);

            string refreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
            user.RefreshToken = refreshToken;
            user.RefreshTokenExpires = expires.AddDays(1);
            await userManagerr.UpdateAsync(user);

            return token;
        }



    }
}
