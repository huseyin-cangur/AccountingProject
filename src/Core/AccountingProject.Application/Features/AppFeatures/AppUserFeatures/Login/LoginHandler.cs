

using AccountingProject.Application.Abstraction;
using AccountingProject.Domain.App.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AccountingProject.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;

        public LoginHandler(UserManager<AppUser> userManager, IJwtProvider jwtProvider)
        {
            _userManager = userManager;
            _jwtProvider = jwtProvider;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            AppUser user = await _userManager.Users.Where(p => p.Email == request.EmailOrUsername || p.UserName == request.EmailOrUsername).FirstOrDefaultAsync();
            if (user == null) throw new Exception("Kullanıcı bulunamadı");

            var checkUser = await _userManager.CheckPasswordAsync(user,request.Password);
            if (!checkUser) throw new Exception("Şifreniz yanlış");

            List<string> roles = new ();

            LoginResponse loginResponse = new ()
            {
                Email=user.Email,
                FullName=user.FullName,
                UserId=user.Id,
                Token= await _jwtProvider.CreateTokenAsync(user,roles),
            };

            return loginResponse;


        }
    }
}